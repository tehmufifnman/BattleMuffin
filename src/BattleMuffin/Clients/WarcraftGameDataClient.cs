using System.Net.Http;
using System.Threading.Tasks;
using BattleMuffin.Enums;
using BattleMuffin.Models.Warcraft.GameData;
using BattleMuffin.Web;

namespace BattleMuffin.Clients
{
    public class WarcraftGameDataClient : BaseClient, IWarcraftGameDataClient
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="WarcraftGameDataClient" /> class.
        /// </summary>
        /// <param name="clientId">The Blizzard OAuth client ID.</param>
        /// <param name="clientSecret">The Blizzard OAuth client secret.</param>
        /// <param name="region">Specifies the <see cref="Region" /> that the API will retrieve its data from.</param>
        /// <param name="locale">
        ///     Specifies the language that the result will be localized in. Visit
        ///     https://develop.battle.net/documentation/guides/regionality-partitions-and-localization
        ///     to see a list of available locales.
        /// </param>
        /// <param name="client">The <see cref="HttpClient" /> to use for all API requests.</param>
        public WarcraftGameDataClient(string clientId, string clientSecret, Region region = Region.US, Locale locale = Locale.en_US, HttpClient? client = null) : base(clientId, clientSecret, region, locale, client)
        {
        }

        public async Task<RequestResult<AchievementCategoryIndex>> GetAchievementCategoryIndexAsync()
        {
            return await Get<AchievementCategoryIndex>($"{Host}/data/wow/achievement-category/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<AchievementCategory>> GetAchievementCategoryAsync(int achievementCategoryId)
        {
            return await Get<AchievementCategory>($"{Host}/data/wow/achievement-category/{achievementCategoryId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }
    }
}
