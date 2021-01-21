using System;
using System.Runtime.Serialization;

namespace usecase.Product
{
    [Serializable]
    internal class DuplicatedProductException : Exception
    {
        private Guid id;

        public DuplicatedProductException()
        {
        }

        public DuplicatedProductException(Guid id)
        {
            this.id = id;
        }

        public DuplicatedProductException(string message) : base(message)
        {
        }

        public DuplicatedProductException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DuplicatedProductException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}