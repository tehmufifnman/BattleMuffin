using System;

namespace BattleMuffin.Exceptions
{
    public class RegionException : Exception
    {
        public RegionException(string message) : base(message)
        {
        }
    }
}
