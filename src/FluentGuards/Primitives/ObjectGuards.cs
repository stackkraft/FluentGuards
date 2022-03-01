namespace FluentGuards.Primitives
{
    public class ObjectGuards : ObjectGuards<ObjectGuards>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectGuards"/> class.
        /// </summary>
        public ObjectGuards(object value) : base(value)
        {
        }
    }

    public class ObjectGuards<TGuards> : ReferenceTypeGuards<object, TGuards>
        where TGuards : ObjectGuards<TGuards>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectGuards{TGuards}"/> class.
        /// </summary>
        public ObjectGuards(object subject) : base(subject)
        {
        }

        /// <summary>
        /// Returns the type of the subject the assertion applies on.
        /// </summary>
        protected override string Identifier => "object";
    }
}
