using System.Threading.Tasks;
using BattleMuffin.Clients;

namespace BattleMuffin.Examples
{
    public class ConsoleApplication
    {
        private readonly IWarcraftClient _warcraftClient;

        public ConsoleApplication(IWarcraftClient warcraftClient)
        {
            _warcraftClient = warcraftClient;
        }

        public async Task Run()
        {
            var achievementCategoriesIndex = await _warcraftClient.GetAchievementCategoriesIndexAsync();
        }
    }
}
