using System;

namespace BattleMuffin.Exceptions
{
    public class ConfigurationException : Exception
    {
        protected ConfigurationException(string message) : base(message) { }
    }
}
