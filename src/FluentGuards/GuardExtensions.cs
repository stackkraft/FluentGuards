using FluentGuards.Primitives;
using System;
using System.Collections.Generic;
namespace FluentGuards
{
    public static class GuardExtensions
    {
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
