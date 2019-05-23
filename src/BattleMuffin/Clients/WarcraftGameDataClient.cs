using System.Net.Http;
using System.Threading.Tasks;
using BattleMuffin.Enums;
using BattleMuffin.Models.Warcraft.GameData;
using BattleMuffin.Web;
using Region = BattleMuffin.Enums.Region;

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

        public async Task<RequestResult<AchievementIndex>> GetAchievementIndexAsync()
        {
            return await Get<AchievementIndex>($"{Host}/data/wow/achievement/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<Achievement>> GetAchievementAsync(int achievementId)
        {
            return await Get<Achievement>($"{Host}/data/wow/achievement/{achievementId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<Media>> GetAchievementMediaAsync(int achievementId)
        {
            return await Get<Media>($"{Host}/data/wow/media/achievement/{achievementId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<ConnectedRealmIndex>> GetConnectedRealmIndexAsync()
        {
            return await Get<ConnectedRealmIndex>($"{Host}/data/wow/connected-realm/index?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<ConnectedRealm>> GetConnectedRealmAsync(int connectedRealmId)
        {
            return await Get<ConnectedRealm>($"{Host}/data/wow/connected-realm/{connectedRealmId}?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<CreatureFamilyIndex>> GetCreatureFamilyIndexAsync()
        {
            return await Get<CreatureFamilyIndex>($"{Host}/data/wow/creature-family/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<CreatureFamily>> GetCreatureFamilyAsync(int creatureFamilyId)
        {
            return await Get<CreatureFamily>($"{Host}/data/wow/creature-family/{creatureFamilyId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<CreatureTypeIndex>> GetCreatureTypeIndexAsync()
        {
            return await Get<CreatureTypeIndex>($"{Host}/data/wow/creature-type/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<CreatureType>> GetCreatureTypeAsync(int creatureTypeId)
        {
            return await Get<CreatureType>($"{Host}/data/wow/creature-type/{creatureTypeId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<Creature>> GetCreatureAsync(int creatureId)
        {
            return await Get<Creature>($"{Host}/data/wow/creature/{creatureId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<Media>> GetCreatureDisplayMediaAsync(int creatureDisplayId)
        {
            return await Get<Media>($"{Host}/data/wow/media/creature-display/{creatureDisplayId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<Media>> GetCreatureFamilyMediaAsync(int creatureFamilyId)
        {
            return await Get<Media>($"{Host}/data/wow/media/creature-family/{creatureFamilyId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<Guild>> GetGuildAsync(string realmSlug, string guildNameSlug)
        {
            return await Get<Guild>($"{Host}/data/wow/guild/{realmSlug}/{guildNameSlug}?namespace={GetNamespace(NamespaceCategory.Profile)}&locale={Locale}");
        }

        public async Task<RequestResult<GuildAchievementIndex>> GetGuildAchievementsAsync(string realmSlug, string guildNameSlug)
        {
            return await Get<GuildAchievementIndex>($"{Host}/data/wow/guild/{realmSlug}/{guildNameSlug}/achievements?namespace={GetNamespace(NamespaceCategory.Profile)}&locale={Locale}");
        }

        public async Task<RequestResult<GuildRoster>> GetGuildRosterAsync(string realmSlug, string guildNameSlug)
        {
            return await Get<GuildRoster>($"{Host}/data/wow/guild/{realmSlug}/{guildNameSlug}/roster?namespace={GetNamespace(NamespaceCategory.Profile)}&locale={Locale}");
        }

        public async Task<RequestResult<GuildCrestComponentsIndex>> GetGuildCrestComponentsIndexAsync()
        {
            return await Get<GuildCrestComponentsIndex>($"{Host}/data/wow/guild-crest/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<Media>> GetGuildCrestBorderMediaAsync(int borderId)
        {
            return await Get<Media>($"{Host}/data/wow/media/guild-crest/border/{borderId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<Media>> GetGuildCrestEmblemMediaAsync(int emblemId)
        {
            return await Get<Media>($"{Host}/data/wow/media/guild-crest/emblem/{emblemId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicKeystoneAffixIndex>> GetMythicKeystoneAffixIndexAsync()
        {
            return await Get<MythicKeystoneAffixIndex>($"{Host}/data/wow/keystone-affix/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicKeystoneAffix>> GetMythicKeystoneAffixAsync(int keystoneAffixId)
        {
            return await Get<MythicKeystoneAffix>($"{Host}/data/wow/keystone-affix/{keystoneAffixId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicRaidLeaderboard>> GetMythicRaidLeaderboardAsync(string raid, string faction)
        {
            return await Get<MythicRaidLeaderboard>($"{Host}/data/wow/leaderboard/hall-of-fame/{raid}/{faction}?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<MountIndex>> GetMountIndexAsync()
        {
            return await Get<MountIndex>($"{Host}/data/wow/mount/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<Mount>> GetMountAsync(int mountId)
        {
            return await Get<Mount>($"{Host}/data/wow/mount/{mountId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicKeystoneDungeonIndex>> GetMythicKeystoneDungeonIndexAsync()
        {
            return await Get<MythicKeystoneDungeonIndex>($"{Host}/data/wow/mythic-keystone/dungeon/index?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicKeystoneDungeon>> GetMythicKeystoneDungeonAsync(int dungeonId)
        {
            return await Get<MythicKeystoneDungeon>($"{Host}/data/wow/mythic-keystone/dungeon/{dungeonId}?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicKeystoneIndex>> GetMythicKeystoneIndexAsync()
        {
            return await Get<MythicKeystoneIndex>($"{Host}/data/wow/mythic-keystone/index?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicKeystonePeriodIndex>> GetMythicKeystonePeriodIndexAsync()
        {
            return await Get<MythicKeystonePeriodIndex>($"{Host}/data/wow/mythic-keystone/period/index?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicKeystonePeriod>> GetMythicKeystonePeriodAsync(int periodId)
        {
            return await Get<MythicKeystonePeriod>($"{Host}/data/wow/mythic-keystone/period/{periodId}?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicKeystoneSeasonIndex>> GetMythicKeystoneSeasonIndexAsync()
        {
            return await Get<MythicKeystoneSeasonIndex>($"{Host}/data/wow/mythic-keystone/season/index?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicKeystoneSeason>> GetMythicKeystoneSeasonAsync(int seasonId)
        {
            return await Get<MythicKeystoneSeason>($"{Host}/data/wow/mythic-keystone/season/{seasonId}?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicKeystoneLeaderboardIndex>> GetMythicKeystoneLeaderboardIndexAsync(int connectedRealmId)
        {
            return await Get<MythicKeystoneLeaderboardIndex>($"{Host}/data/wow/connected-realm/{connectedRealmId}/mythic-leaderboard/index?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<MythicKeystoneLeaderboard>> GetMythicKeystoneLeaderboardAsync(int connectedRealmId, int dungeonId, int periodId)
        {
            return await Get<MythicKeystoneLeaderboard>($"{Host}/data/wow/connected-realm/{connectedRealmId}/mythic-leaderboard/{dungeonId}/period/{periodId}?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<BattlePetIndex>> GetBattlePetIndexAsync()
        {
            return await Get<BattlePetIndex>($"{Host}/data/wow/pet/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<BattlePet>> GetBattlePetAsync(int petId)
        {
            return await Get<BattlePet>($"{Host}/data/wow/pet/{petId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<PlayableClassIndex>> GetPlayableClassIndexAsync()
        {
            return await Get<PlayableClassIndex>($"{Host}/data/wow/playable-class/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<PlayableClass>> GetPlayableClassAsync(int classId)
        {
            return await Get<PlayableClass>($"{Host}/data/wow/playable-class/{classId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<PlayableClassPvPTalentSlots>> GetPlayableClassPvPTalentSlotsAsync(int classId)
        {
            return await Get<PlayableClassPvPTalentSlots>($"{Host}/data/wow/playable-class/{classId}/pvp-talent-slots?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<PlayableSpecializationIndex>> GetPlayableSpecializationIndexAsync()
        {
            return await Get<PlayableSpecializationIndex>($"{Host}/data/wow/playable-specialization/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<PlayableSpecialization>> GetPlayableSpecializationAsync(int specId)
        {
            return await Get<PlayableSpecialization>($"{Host}/data/wow/playable-specialization/{specId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<PowerTypeIndex>> GetPowerTypeIndexAsync()
        {
            return await Get<PowerTypeIndex>($"{Host}/data/wow/power-type/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<PowerType>> GetPowerTypeAsync(int powerTypeId)
        {
            return await Get<PowerType>($"{Host}/data/wow/power-type/{powerTypeId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<PvPSeasonIndex>> GetPvPSeasonIndexAsync()
        {
            return await Get<PvPSeasonIndex>($"{Host}/data/wow/pvp-season/index?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<PvPSeason>> GetPvPSeasonAsync(int pvpSeasonId)
        {
            return await Get<PvPSeason>($"{Host}/data/wow/pvp-season/{pvpSeasonId}?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<PvPSeasonLeaderboardIndex>> GetPvPSeasonLeaderboardIndexAsync(int pvpSeasonId)
        {
            return await Get<PvPSeasonLeaderboardIndex>($"{Host}/data/wow/pvp-season/{pvpSeasonId}/pvp-leaderboard/index?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<PvPSeasonLeaderboard>> GetPvPSeasonLeaderboardAsync(int pvpSeasonId, string pvpBracket)
        {
            return await Get<PvPSeasonLeaderboard>($"{Host}/data/wow/pvp-season/{pvpSeasonId}/pvp-leaderboard/{pvpBracket}?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<PvPSeasonRewardIndex>> GetPvPSeasonRewardIndexAsync(int pvpSeasonId)
        {
            return await Get<PvPSeasonRewardIndex>($"{Host}/data/wow/pvp-season/{pvpSeasonId}/pvp-reward/index?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<Media>> GetPvPTierMediaAsync(int pvpTierId)
        {
            return await Get<Media>($"{Host}/data/wow/media/pvp-tier/{pvpTierId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<PvPTierIndex>> GetPvPTierIndexAsync()
        {
            return await Get<PvPTierIndex>($"{Host}/data/wow/pvp-tier/index?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<PvPTier>> GetPvPTierAsync(int pvpTierId)
        {
            return await Get<PvPTier>($"{Host}/data/wow/pvp-tier/{pvpTierId}?namespace={GetNamespace(NamespaceCategory.Static)}&locale={Locale}");
        }

        public async Task<RequestResult<RealmIndex>> GetRealmIndexAsync()
        {
            return await Get<RealmIndex>($"{Host}/data/wow/realm/index?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }

        public async Task<RequestResult<Realm>> GetRealmAsync(string realmSlug)
        {
            return await Get<Realm>($"{Host}/data/wow/realm/{realmSlug}?namespace={GetNamespace(NamespaceCategory.Dynamic)}&locale={Locale}");
        }
    }
}
