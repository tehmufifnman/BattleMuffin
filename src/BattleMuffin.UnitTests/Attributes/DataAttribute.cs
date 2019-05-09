using System;
using System.Reflection;

namespace BattleMuffin.UnitTests.Attributes
{
    public abstract class DataAttribute : Attribute
    {
        public abstract object GetData(MethodInfo testMethod);
    }
}