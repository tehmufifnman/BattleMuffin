using System;
using System.Reflection;
using BattleMuffin.Exceptions;

namespace BattleMuffin.Extensions
{
    public static class AttributeExtensions
    {
        public static T GetAttribute<T>(this Enum enumVal) where T : Attribute
        {
            var type = enumVal.GetType();

            var memInfo = type.GetField(enumVal.ToString());
            if (memInfo == null) throw new AttributeException("There was an error accessing field attribute.");

            var attribute = memInfo.GetCustomAttribute(typeof(T), false);
            if (attribute == null) throw new AttributeException("Attribute was not found.");

            return (T) attribute;
        }
    }
}
