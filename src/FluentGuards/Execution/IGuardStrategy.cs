using System.Collections.Generic;

namespace FluentGuards.Execution
{
    /// <summary>
    /// Defines a strategy for handling failures in a <see cref="GuardScope"/>.
    /// </summary>
    public interface IGuardStrategy
    {
        /// <summary>
        /// Returns the messages for the Guard failures that happened until now.
        /// </summary>
        IEnumerable<string> FailureMessages { get; }

        /// <summary>
        /// Instructs the strategy to handle a Guard failure.
        /// </summary>
        void HandleFailure(string message);

        /// <summary>
        /// Discards and returns the failure messages that happened up to now.
        /// </summary>
        IEnumerable<string> DiscardFailures();

        /// <summary>
        /// Will throw a combined exception for any failures have been collected.
        /// </summary>
        void ThrowIfAny(IDictionary<string, object> context);
    }
}
