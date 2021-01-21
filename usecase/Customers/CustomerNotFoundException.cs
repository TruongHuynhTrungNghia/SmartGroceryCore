using System;

namespace usecase.Customers
{
    [Serializable]
    internal class CustomerNotFoundException : Exception
    {
        public Guid Id { get; }

        public CustomerNotFoundException()
        {
        }

        public CustomerNotFoundException(Guid id)
            : this(id, $"Could not found customer with {id}")
        {
        }

        public CustomerNotFoundException(Guid id, string message)
            : this(message)
        {
            Id = id;
        }

        public CustomerNotFoundException(string message) : base(message)
        {
        }
    }
}