using System;

namespace BattleMuffin.Attributes
{
    public class RfcTagAttribute : Attribute
    {
        internal string Tag { get; }

        internal RfcTagAttribute(string tag)
        {
            Tag = tag;
        }
    }
}
