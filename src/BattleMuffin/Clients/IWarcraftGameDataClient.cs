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

        Task<RequestResult<CreatureFamilyIndex>> GetCreatureFamilyIndexAsync();

        Task<RequestResult<CreatureFamily>> GetCreatureFamilyAsync(int creatureFamilyId);

        Task<RequestResult<CreatureTypeIndex>> GetCreatureTypeIndexAsync();

        Task<RequestResult<CreatureType>> GetCreatureTypeAsync(int creatureTypeId);

        Task<RequestResult<Creature>> GetCreatureAsync(int creatureId);

        Task<RequestResult<Media>> GetCreatureDisplayMediaAsync(int creatureDisplayId);

        Task<RequestResult<Media>> GetCreatureFamilyMediaAsync(int creatureFamilyId);

        Task<RequestResult<Guild>> GetGuildAsync(string realmSlug, string guildNameSlug);

        Task<RequestResult<GuildAchievementIndex>> GetGuildAchievementsAsync(string realmSlug, string guildNameSlug);

        Task<RequestResult<GuildRoster>> GetGuildRosterAsync(string realmSlug, string guildNameSlug);

        Task<RequestResult<GuildCrestComponentsIndex>> GetGuildCrestComponentsIndexAsync();

        Task<RequestResult<Media>> GetGuildCrestBorderMediaAsync(int borderId);

        Task<RequestResult<Media>> GetGuildCrestEmblemMediaAsync(int emblemId);

        Task<RequestResult<MythicKeystoneAffixIndex>> GetMythicKeystoneAffixIndexAsync();

        Task<RequestResult<MythicKeystoneAffix>> GetMythicKeystoneAffixAsync(int keystoneAffixId);

        Task<RequestResult<MythicRaidLeaderboard>> GetMythicRaidLeaderboardAsync(string raid, string faction);

        Task<RequestResult<MountIndex>> GetMountIndexAsync();

        Task<RequestResult<Mount>> GetMountAsync(int mountId);
    }
}
