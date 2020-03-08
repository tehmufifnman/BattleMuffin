using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;

namespace BattleMuffin.Web
{
    internal static class InternalHttpClient
    {
        private static HttpClient? _instance;

        public static HttpClient Instance
        {
            get
            {
                if (_instance != null) return _instance;

                var handler = new TimeoutHandler
                {
                    InnerHandler = new HttpClientHandler
                    {
                        AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                    }
                };

                _instance = new HttpClient(handler);
                _instance.DefaultRequestHeaders.Accept.Clear();
                _instance.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                _instance.Timeout = Timeout.InfiniteTimeSpan;

                return _instance;
            }
        }
    }
}
