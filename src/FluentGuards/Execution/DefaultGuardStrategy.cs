using System.Collections.Generic;

using FluentGuards.Common;

namespace FluentGuards.Execution
{
    internal class DefaultGuardStrategy : IGuardStrategy
    {
        /// <summary>
        /// Returns the messages for the Guard failures that happened until now.
        /// </summary>
        public IEnumerable<string> FailureMessages
        {
            get
            {
                return new string[0];
            }
        }

        /// <summary>
        /// Instructs the strategy to handle a Guard failure.
        /// </summary>
        public void HandleFailure(string message)
        {
            Services.ThrowException(message);
        }

        /// <summary>
        /// Discards and returns the failure messages that happened up to now.
        /// </summary>
        public IEnumerable<string> DiscardFailures()
        {
            return new string[0];
        }

        /// <summary>
        /// Will throw a combined exception for any failures have been collected.
        /// </summary>
        public void ThrowIfAny(IDictionary<string, object> context)
        {
        }
    }
}
