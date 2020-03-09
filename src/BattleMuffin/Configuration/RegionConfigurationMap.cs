using System.Collections.Generic;
using System.Globalization;
using BattleMuffin.Enums;
using BattleMuffin.Extensions;

namespace BattleMuffin.Configuration
{
    internal static class RegionConfigurationMap
    {
        internal static readonly IReadOnlyDictionary<Region, RegionConfiguration> Mapping =
            new Dictionary<Region, RegionConfiguration>
            {
                {
                    Region.US, new RegionConfiguration
                    (
                        nameof(Region.US).ToLower(),
                        new List<CultureInfo>
                        {
                            new CultureInfo("en-US", false),
                            new CultureInfo("es_MX", false),
                            new CultureInfo("pt_BR", false)
                        }
                    )
                },
                {
                    Region.EU, new RegionConfiguration
                    (
                        nameof(Region.EU).ToLower(),
                        new List<CultureInfo>
                        {
                            new CultureInfo("en_GB", false),
                            new CultureInfo("es_ES", false),
                            new CultureInfo("fr_FR", false),
                            new CultureInfo("ru_RU", false),
                            new CultureInfo("de_DE", false),
                            new CultureInfo("pt_PT", false),
                            new CultureInfo("it_IT", false)
                        }
                    )
                },
                {
                    Region.KR, new RegionConfiguration
                    (
                        nameof(Region.KR).ToLower(),
                        new List<CultureInfo>
                        {
                            new CultureInfo("ko_KR", false)
                        }
                    )
                },
                {
                    Region.TW, new RegionConfiguration
                    (
                        nameof(Region.TW).ToLower(),
                        new List<CultureInfo>
                        {
                            new CultureInfo("zh_TW", false)
                        }
                    )
                },
                {
                    Region.CN, new RegionConfiguration
                    (
                        nameof(Region.CN).ToLower(),
                        new List<CultureInfo>
                        {
                            new CultureInfo("zh_TW", false)
                        },
                        "https://gateway.battlenet.com.cn/",
                        "https://www.battlenet.com.cn"
                    )
                }
            };
    }
}
