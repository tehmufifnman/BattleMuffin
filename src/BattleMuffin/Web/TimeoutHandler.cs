using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using BattleMuffin.Extensions;

namespace BattleMuffin.Web
{
    internal class TimeoutHandler : DelegatingHandler
    {
        private TimeSpan DefaultTimeout { get; } = TimeSpan.FromSeconds(100);

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            using var cts = GetCancellationTokenSource(request, cancellationToken);
            return await base.SendAsync(request, cts?.Token ?? cancellationToken);
        }

        private CancellationTokenSource? GetCancellationTokenSource(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            var timeout = request.GetTimeout() ?? DefaultTimeout;
            if (timeout == Timeout.InfiniteTimeSpan) return null;

            var cts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
            cts.CancelAfter(timeout);
            return cts;
        }
    }
}
