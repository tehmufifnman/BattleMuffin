using System;
using System.Net.Http;

namespace BattleMuffin.Extensions
{
    internal static class HttpRequestExtensions
    {
        private const string TimeoutPropertyKey = "RequestTimeout";

        internal static HttpRequestMessage SetTimeout(this HttpRequestMessage request, TimeSpan? timeout)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            request.Properties[TimeoutPropertyKey] = timeout;
            return request;
        }

        internal static TimeSpan? GetTimeout(this HttpRequestMessage request)
        {
            if (request == null) throw new ArgumentNullException(nameof(request));

            if (request.Properties.TryGetValue(TimeoutPropertyKey, out var value) && value is TimeSpan timeout)
                return timeout;

            return null;
        }
    }
}
