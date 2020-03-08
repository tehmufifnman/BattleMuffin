using System;

namespace BattleMuffin.Attributes
{
    public class PrefixAttribute : Attribute
    {
        internal string Prefix { get; }

        internal PrefixAttribute(string prefix)
        {
            Prefix = prefix;
        }
    }
}
