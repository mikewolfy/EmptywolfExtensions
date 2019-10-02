using System;

namespace Emptywolf.Extensions
{
    public static class EnumExtensions
    {
        public static T MapToEnum<T>(this string enumValue, T defaultValue = default(T)) where T : Enum
        {
            if (enumValue != null && Enum.IsDefined(typeof(T), enumValue))
            {
                return (T)Enum.Parse(typeof(T), enumValue);
            }
            else
            {
                return defaultValue;
            }
        }
    }
}
