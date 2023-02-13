using System;

namespace Avanade.BestPractices.Infrestructure.Core.Extensions
{
    public static class EnumExtensions
    {

        public static int ToInt(this Enum value)
        {
            return Convert.ToInt32(value);
        }
    }
}
