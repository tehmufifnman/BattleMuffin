using BattleMuffin.Attributes;

namespace BattleMuffin.Enums
{
    public enum Region
    {
        [Prefix("us")]
        US,

        [Prefix("eu")]
        EU,

        [Prefix("kr")]
        KR,

        [Prefix("tw")]
        TW,

        [Prefix("cn")]
        CN
    }
}
