namespace lab1.Storage
{
    [System.Serializable]
    public class IncorrectFlatException : System.Exception
    {
        public IncorrectFlatException() { }
        public IncorrectFlatException(string message) : base(message) { }
        public IncorrectFlatException(string message, System.Exception inner) : base(message, inner) { }
        protected IncorrectFlatException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}