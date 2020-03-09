using System;
using System.Threading.Tasks;
using BattleMuffin.Models;

namespace BattleMuffin.Clients
{
    internal class WarcraftClient : IWarcraftClient
    {
        private readonly BattleMuffinClientFactory _battleMuffinClientFactory;

        public WarcraftClient(BattleMuffinClientFactory battleMuffinClientFactory)
        {
            _battleMuffinClientFactory = battleMuffinClientFactory ?? throw new ArgumentNullException(nameof(battleMuffinClientFactory));
        }

        public async Task<AchievementCategoriesIndex> GetAchievementCategoriesIndexAsync()
        {
            var client = _battleMuffinClientFactory.Create();
            var achievementCategoriesIndex = await client.Get<AchievementCategoriesIndex>("/data/wow/achievement-category/index", "static-us");
            return achievementCategoriesIndex;
        }
    }
}
