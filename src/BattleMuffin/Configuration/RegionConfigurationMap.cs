using System.Collections.Generic;
using BattleMuffin.Attributes;
using BattleMuffin.Enums;
using BattleMuffin.Exceptions;
using BattleMuffin.Extensions;

namespace BattleMuffin.Configuration
{
    internal static class RegionConfigurationMap
    {
        internal static readonly Dictionary<Region, RegionConfiguration> Mapping =
            new Dictionary<Region, RegionConfiguration>
            {
                {
                    Region.US, new RegionConfiguration
                    (
                        Region.US.GetAttribute<PrefixAttribute>().Prefix,
                        new List<Locale>
                        {
                            Locale.EnglishUS,
                            Locale.SpanishMX,
                            Locale.PortugueseBR
                        }
                    )
                },
                {
                    Region.EU, new RegionConfiguration
                    (
                        Region.EU.GetAttribute<PrefixAttribute>().Prefix,
                        new List<Locale>
                        {
                            Locale.EnglishGB,
                            Locale.SpanishES,
                            Locale.FrenchFR,
                            Locale.RussianRU,
                            Locale.GermanDE,
                            Locale.PortuguesePT,
                            Locale.ItalyIT
                        }
                    )
                },
                {
                    Region.KR, new RegionConfiguration
                    (
                        Region.KR.GetAttribute<PrefixAttribute>().Prefix,
                        new List<Locale>
                        {
                            Locale.KoreanKR
                        }
                    )
                },
                {
                    Region.TW, new RegionConfiguration
                    (
                        Region.TW.GetAttribute<PrefixAttribute>().Prefix,
                        new List<Locale>
                        {
                            Locale.ChineseTW
                        }
                    )
                },
                {
                    Region.CN, new RegionConfiguration
                    (
                        Region.CN.GetAttribute<PrefixAttribute>().Prefix,
                        "https://gateway.battlenet.com.cn/",
                        new List<Locale>
                        {
                            Locale.ChineseCN
                        }
                    )
                }
            };
    }
}
