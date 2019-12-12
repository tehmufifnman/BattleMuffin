using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;

namespace BattleMuffin.Clients
{
    /// <summary>
    ///     An internal HttpClient singleton class to be used for the lifetime of the application.
    /// </summary>
    internal static class InternalHttpClient
    {
        private static HttpClient _instance;

        /// <summary>
        ///     Gets the current HttpClient instance.
        /// </summary>
        public static HttpClient Instance
        {
            get
            {
                if (_instance != null) return _instance;

                var handler = new SocketsHttpHandler
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
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
