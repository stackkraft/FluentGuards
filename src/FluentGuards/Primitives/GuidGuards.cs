using System;

namespace FluentGuards.Primitives
{
    public class GuidGuards : GuidGuards<GuidGuards>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidGuards"/> class.
        /// </summary>
        public GuidGuards(Guid? value) : base(value)
        {
        }
    }

    public class GuidGuards<TGuards>
        where TGuards : GuidGuards<TGuards>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GuidGuards{TGuards}"/> class.
        /// </summary>
        public GuidGuards(Guid? subject)
        {
            this.Subject = subject;
        }

        /// <summary>
        /// Gets the object which value is being asserted.
        /// </summary>
        public Guid? Subject { get; }

        public AndConstraint<TGuards> NotBeEmpty(string because = "", params object[] becauseArgs)
        {
            // TODO Implement

            return new AndConstraint<TGuards>((TGuards)this);
        }
    }
}
