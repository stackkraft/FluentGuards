using System;
using System.Diagnostics;

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

        public AndConstraint<TGuards> NotBeEmpty(string paramName, string because = "", params object[] becauseArgs)
        {
            if (this.Subject.Equals(Guid.Empty))
            {
                throw new ArgumentException("Guid must not be empty!", paramName);
            }

            return new AndConstraint<TGuards>((TGuards)this);
        }
    }
}
