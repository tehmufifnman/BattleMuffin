using BattleMuffin.Attributes;

namespace BattleMuffin.Enums
{
    /// <summary>
    ///     Represents the different locales supported by the Blizzard API.
    /// </summary>
    public enum Locale
    {
        /// <summary>
        ///     English (United States of America)
        /// </summary>
        [LocaleRegion(Region.Us)]
        EnUs,

        /// <summary>
        ///     Spanish (Mexico)
        /// </summary>
        [LocaleRegion(Region.Us)]
        EsMx,

        /// <summary>
        ///     Portuguese (Brazil)
        /// </summary>
        [LocaleRegion(Region.Us)]
        PtBr,

        /// <summary>
        ///     English (United Kingdom)
        /// </summary>
        [LocaleRegion(Region.Europe)]
        EnGb,

        /// <summary>
        ///     Spanish (Spain)
        /// </summary>
        [LocaleRegion(Region.Europe)]
        EsEs,

        /// <summary>
        ///     French (France)
        /// </summary>
        [LocaleRegion(Region.Europe)]
        FrFr,

        /// <summary>
        ///     Russian (Russian Federation)
        /// </summary>
        [LocaleRegion(Region.Europe)]
        RuRu,

        /// <summary>
        ///     German (Germany)
        /// </summary>
        [LocaleRegion(Region.Europe)]
        DeDe,

        /// <summary>
        ///     Portuguese (Portugal)
        /// </summary>
        [LocaleRegion(Region.Europe)]
        PtPt,

        /// <summary>
        ///     Italian (Italy)
        /// </summary>
        [LocaleRegion(Region.Europe)]
        ItIt,

        /// <summary>
        ///     Korean (Korea)
        /// </summary>
        [LocaleRegion(Region.Korea)]
        KoKr,

        /// <summary>
        ///     Chinese (Taiwan)
        /// </summary>
        [LocaleRegion(Region.Taiwan)]
        ZhTw,

        /// <summary>
        ///     Chinese (China)
        /// </summary>
        [LocaleRegion(Region.China)]
        ZhCn
    }
}
