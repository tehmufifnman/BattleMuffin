using System.Reflection;
using BattleMuffin.Attributes;
using BattleMuffin.Enums;

namespace BattleMuffin.Extensions
{
    internal static class EnumExtensions
    {
        public static string BuildQueryString(this CharacterFields fields)
        {
            switch (fields)
            {
                case CharacterFields.All:
                    return "&fields=achievements,appearance,feed,guild,hunter pets,items,mounts,pets,pet slots,professions,progression,pvp,quests,reputation,statistics,stats,talents,titles,audit";
                case CharacterFields.None:
                    return string.Empty;
                default:
                    var flags = fields.ToString().ToLower();
                    return $"&fields={flags}";
            }
        }

        public static string BuildQueryString(this GuildFields fields)
        {
            switch (fields)
            {
                case GuildFields.All:
                    return "&fields=members,achievements,news,challenge";
                case GuildFields.None:
                    return string.Empty;
                default:
                    var flags = fields.ToString().ToLower();
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
