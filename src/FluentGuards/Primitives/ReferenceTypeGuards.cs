using System;

namespace FluentGuards.Primitives
{
    #pragma warning disable CS0659 // Ignore not overriding Object.GetHashCode()

    public abstract class ReferenceTypeGuards<TSubject, TGuards>
        where TGuards : ReferenceTypeGuards<TSubject, TGuards>
    {
        protected ReferenceTypeGuards(TSubject subject)
        {
            this.Subject = subject;
        }

        public TSubject Subject { get; }

        public AndConstraint<TGuards> NotBeNull(string because = "", params object[] becauseArgs)
        {
            // TODO Implement

            return new AndConstraint<TGuards>((TGuards)this);
        }

        /// <summary>
        /// Returns the type of the subject the guard applies on.
        /// It should be a user-friendly name as it is included in the failure message.
        /// </summary>
        protected abstract string Identifier { get; }

        /// <inheritdoc/>
        public override bool Equals(object obj) =>
            throw new NotSupportedException("Calling Equals on Guards classes is not supported.");
    }
}