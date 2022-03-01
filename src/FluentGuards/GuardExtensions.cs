using FluentGuards.Primitives;
using System;

namespace FluentGuards
{
    public static class GuardExtensions
    {
        public static ObjectGuards Must(this object actualValue)
        {
            return new ObjectGuards(actualValue);
        }

        public static StringGuards Must(this string actualValue)
        {
            return new StringGuards(actualValue);
        }

        public static GuidGuards Must(this Guid actualValue)
        {
            return new GuidGuards(actualValue);
        }

        public static NullableGuidGuards Must(this Guid? actualValue)
        {
            return new NullableGuidGuards(actualValue);
        }
    }
}
