using System.Reflection;
using BattleMuffin.Attributes;
using BattleMuffin.Enums;

namespace BattleMuffin.Extensions
{
    internal static class EnumExtensions
    {
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
