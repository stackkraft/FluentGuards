using System;

namespace FluentGuards.Primitives
{
    public class StringGuards : StringGuards<StringGuards>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringGuards"/> class.
        /// </summary>
        public StringGuards(string value) : base(value)
        {
        }
    }

    public class StringGuards<TGuards> : ReferenceTypeGuards<string, TGuards>
        where TGuards : StringGuards<TGuards>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringGuards{TGuards}"/> class.
        /// </summary>
        public StringGuards(string subject) : base(subject)
        {
        }

        public AndConstraint<TGuards> NotBeNullOrEmpty(string paramName, string because = "", params object[] becauseArgs)
        {
            if (string.IsNullOrEmpty(this.Subject))
            {
                throw new ArgumentException("String must not be null or empty!", paramName);
            }

            return new AndConstraint<TGuards>((TGuards)this);
        }

        public AndConstraint<TGuards> NotBeNullOrWhiteSpace(string paramName, string because = "", params object[] becauseArgs)
        {
            if (string.IsNullOrWhiteSpace(this.Subject))
            {
                throw new ArgumentException("String must not be null, empty or whitespace!", paramName);
            }

            return new AndConstraint<TGuards>((TGuards)this);
        }

        /// <summary>
        /// Returns the type of the subject the assertion applies on.
        /// </summary>
        protected override string Identifier => "string";
    }
}
