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

        public AndConstraint<TGuards> NotBeNullOrEmpty(string because = "", params object[] becauseArgs)
        {
            // TODO Implement

            return new AndConstraint<TGuards>((TGuards)this);
        }

        public AndConstraint<TGuards> NotBeNullOrWhiteSpace(string because = "", params object[] becauseArgs)
        {
            // TODO Implement

            return new AndConstraint<TGuards>((TGuards)this);
        }

        /// <summary>
        /// Returns the type of the subject the assertion applies on.
        /// </summary>
        protected override string Identifier => "string";
    }
}
