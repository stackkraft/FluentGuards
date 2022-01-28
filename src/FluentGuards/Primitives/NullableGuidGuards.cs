using System;

namespace FluentGuards.Primitives
{
    public class NullableGuidGuards : NullableGuidGuards<NullableGuidGuards>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullableGuidGuards"/> class.
        /// </summary>
        public NullableGuidGuards(Guid? value) : base(value)
        {
        }
    }

    public class NullableGuidGuards<TGuards> : GuidGuards<TGuards>
        where TGuards : NullableGuidGuards<TGuards>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NullableGuidGuards{TGuards}"/> class.
        /// </summary>
        public NullableGuidGuards(Guid? value) : base(value)
        {
        }

        public AndConstraint<TGuards> HaveValue(string because = "", params object[] becauseArgs)
        {
            return new AndConstraint<TGuards>((TGuards)this);
        }

        public AndConstraint<TGuards> NotBeNull(string because = "", params object[] becauseArgs)
        {
            return HaveValue(because, becauseArgs);
        }
    }
}
