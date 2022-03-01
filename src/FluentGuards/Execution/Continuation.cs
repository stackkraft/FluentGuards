//namespace FluentGuards.Execution
//{
//    /// <summary>
//    /// Enables chaining multiple assertions on an <see cref="GuardScope"/>.
//    /// </summary>
//    public class Continuation
//    {
//        private readonly GuardScope sourceScope;
//        private readonly bool continueAsserting;

//        internal Continuation(GuardScope sourceScope, bool continueAsserting)
//        {
//            this.sourceScope = sourceScope;
//            this.continueAsserting = continueAsserting;
//        }

//        /// <summary>
//        /// Continuous the assertion chain if the previous assertion was successful.
//        /// </summary>
//        public IGuardScope Then
//        {
//            get
//            {
//                return new ContinuedGuardScope(sourceScope, continueAsserting);
//            }
//        }

//        /// <summary>
//        /// Provides back-wards compatibility for code that expects <see cref="AssertionScope.FailWith(string, object[])"/> to return a boolean.
//        /// </summary>
//        public static implicit operator bool(Continuation continuation)
//        {
//            return continuation.continueAsserting;
//        }
//    }
//}
