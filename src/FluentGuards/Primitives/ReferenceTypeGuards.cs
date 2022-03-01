using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

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

        public AndConstraint<TGuards> NotBeNull(string paramName, string because = "", params object[] becauseArgs)
        {
            if (this.Subject is null)
            {
                throw new ArgumentNullException(paramName);
            }

            return new AndConstraint<TGuards>((TGuards)this);
        }

        //[return: NotNull]
        //public static T NotBeNull<T>([NotNull] this T? obj, string? message = default, [CallerArgumentExpression("obj")] string? parameterName = default)
        //where T : class
        //{
        //    return obj ?? throw new ArgumentNullException(parameterName, message);
        //}

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