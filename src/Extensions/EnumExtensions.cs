using BattleMuffin.Enums;

namespace BattleMuffin.Extensions
{
    internal static class EnumExtensions
    {
        public static string BuildQueryString(this CharacterFields fields)
        {
            // The Blizzard API only accepts lowercase fields.
            var flags = fields.ToString().ToLower();

            switch (flags)
            {
                case "all":
                    return "&fields=achievements,appearance,feed,guild,hunter pets,items,mounts,pets,pet slots," +
                           "professions,progression,pvp,quests,reputation,statistics,stats,talents,titles,audit";
                case "none":
                    return string.Empty;
                default:
                    return ($"&fields={flags}");
            }
        }

        public static string BuildQueryString(this GuildFields fields)
        {
            // The Blizzard API only accepts lowercase fields.
            var flags = fields.ToString().ToLower();

            switch (flags)
            {
                case "all":
                    return "&fields=members,achievements,news,challenge";
                case "none":
                    return string.Empty;
                default:
                    return ($"&fields={flags}");
            }
        }
    }
}
