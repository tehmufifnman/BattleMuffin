using System;
using BattleMuffin.Enums;

namespace BattleMuffin.Attributes
{
    /// <summary>
    ///     Attribute used to set a valid <see cref="Region" /> for a given <see cref="Locale" />.
    /// </summary>
    public sealed class LocaleRegion : Attribute
    {
        /// <summary>
        ///     Sets the <see cref="Region" /> of the attribute.
        /// </summary>
        public Region Region { get; }

        /// <summary>
        ///     Sets a valid <see cref="Region" /> for a <see cref="Locale" />.
        /// </summary>
        /// <param name="region">The valid <see cref="Region" />.</param>
        public LocaleRegion(Region region)
        {
            Region = region;
        }
    }
}
