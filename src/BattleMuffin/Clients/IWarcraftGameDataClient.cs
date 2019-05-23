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

        Task<RequestResult<MythicKeystoneDungeonIndex>> GetMythicKeystoneDungeonIndexAsync();

        Task<RequestResult<MythicKeystoneDungeon>> GetMythicKeystoneDungeonAsync(int dungeonId);

        Task<RequestResult<MythicKeystoneIndex>> GetMythicKeystoneIndexAsync();

        Task<RequestResult<MythicKeystonePeriodIndex>> GetMythicKeystonePeriodIndexAsync();

        Task<RequestResult<MythicKeystonePeriod>> GetMythicKeystonePeriodAsync(int periodId);

        Task<RequestResult<MythicKeystoneSeasonIndex>> GetMythicKeystoneSeasonIndexAsync();

        Task<RequestResult<MythicKeystoneSeason>> GetMythicKeystoneSeasonAsync(int seasonId);

        Task<RequestResult<MythicKeystoneLeaderboardIndex>> GetMythicKeystoneLeaderboardIndexAsync(int connectedRealmId);

        Task<RequestResult<MythicKeystoneLeaderboard>> GetMythicKeystoneLeaderboardAsync(int connectedRealmId, int dungeonId, int periodId);

        Task<RequestResult<BattlePetIndex>> GetBattlePetIndexAsync();

        Task<RequestResult<BattlePet>> GetBattlePetAsync(int petId);

        Task<RequestResult<PlayableClassIndex>> GetPlayableClassIndexAsync();

        Task<RequestResult<PlayableClass>> GetPlayableClassAsync(int classId);

        Task<RequestResult<PlayableClassPvPTalentSlots>> GetPlayableClassPvPTalentSlotsAsync(int classId);

        Task<RequestResult<PlayableSpecializationIndex>> GetPlayableSpecializationIndexAsync();

        Task<RequestResult<PlayableSpecialization>> GetPlayableSpecializationAsync(int specId);

        Task<RequestResult<PowerTypeIndex>> GetPowerTypeIndexAsync();

        Task<RequestResult<PowerType>> GetPowerTypeAsync(int powerTypeId);

        Task<RequestResult<PvPSeasonIndex>> GetPvPSeasonIndexAsync();

        Task<RequestResult<PvPSeason>> GetPvPSeasonAsync(int pvpSeasonId);

        Task<RequestResult<PvPSeasonLeaderboardIndex>> GetPvPSeasonLeaderboardIndexAsync(int pvpSeasonId);

        Task<RequestResult<PvPSeasonLeaderboard>> GetPvPSeasonLeaderboardAsync(int pvpSeasonId, string pvpBracket);

        Task<RequestResult<PvPSeasonRewardIndex>> GetPvPSeasonRewardIndexAsync(int pvpSeasonId);

        Task<RequestResult<Media>> GetPvPTierMediaAsync(int pvpTierId);

        Task<RequestResult<PvPTierIndex>> GetPvPTierIndexAsync();

        Task<RequestResult<PvPTier>> GetPvPTierAsync(int pvpTierId);

        Task<RequestResult<RealmIndex>> GetRealmIndexAsync();

        Task<RequestResult<Realm>> GetRealmAsync(string realmSlug);

        Task<RequestResult<RegionIndex>> GetRegionIndexAsync();

        Task<RequestResult<Region>> GetRegionAsync(int regionId);

        Task<RequestResult<WoWTokenIndex>> GetWoWTokenIndexAsync();
    }
}
