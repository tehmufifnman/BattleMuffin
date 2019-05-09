using System.Reflection;
using BattleMuffin.Attributes;
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
                    return $"&fields={flags}";
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
                    return $"&fields={flags}";
            }
        }

        /// <summary>
        ///     Checks if the locale is supported by the selected region.
        /// </summary>
        /// <param name="locale">The selected locale.</param>
        /// <param name="region">The selected region.</param>
        /// <returns>Returns true if the locale is supported by the selected region.</returns>
        public static bool ValidateRegionLocale(this Locale locale, Region region)
        {
            var type = locale.GetType().GetRuntimeField(locale.ToString());
            var attribute = type.GetCustomAttribute<LocaleRegion>();

            return attribute.Region == region;
        }
    }
}
