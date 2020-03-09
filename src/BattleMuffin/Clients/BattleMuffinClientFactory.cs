using System;
using Microsoft.Extensions.DependencyInjection;

namespace BattleMuffin.Clients
{
    internal class BattleMuffinClientFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public BattleMuffinClientFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        internal BattleMuffinClient Create()
        {
            return _serviceProvider.GetRequiredService<BattleMuffinClient>();
        }
    }
}
