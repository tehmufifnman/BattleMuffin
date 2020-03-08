using System;

namespace BattleMuffin.Attributes
{
    public class PrefixAttribute : Attribute
    {
        internal string Prefix { get; }

        public PrefixAttribute(string prefix)
        {
            Prefix = prefix;
        }
    }
}
