using System;
using BattleMuffin.Enums;

namespace BattleMuffin.Exceptions
{
    public class InvalidRegionException : Exception
    {
        public InvalidRegionException()
        {
        }

        public InvalidRegionException(Region region) : base(
            $"Invalid Student Name: {region}.  This region cannot be used with the World of Warcraft Game Data API.")
        {
        }
    }
}
