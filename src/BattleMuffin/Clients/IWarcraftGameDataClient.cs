using System.Threading.Tasks;
using BattleMuffin.Models.Warcraft.GameData;
using BattleMuffin.Web;

namespace BattleMuffin.Clients
{
    public interface IWarcraftGameDataClient
    {
        Task<RequestResult<AchievementCategoryIndex>> GetAchievementCategoryIndexAsync();

        Task<RequestResult<AchievementCategory>> GetAchievementCategoryAsync(int achievementCategoryId);

        Task<RequestResult<AchievementIndex>> GetAchievementIndexAsync();

        Task<RequestResult<Achievement>> GetAchievementAsync(int achievementId);

        Task<RequestResult<Media>> GetAchievementMediaAsync(int achievementMediaId);

        Task<RequestResult<ConnectedRealmIndex>> GetConnectedRealmIndexAsync();

        Task<RequestResult<ConnectedRealm>> GetConnectedRealmAsync(int connectedRealmId);
    }
}
