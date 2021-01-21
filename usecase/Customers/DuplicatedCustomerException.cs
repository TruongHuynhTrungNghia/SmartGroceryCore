using System;

namespace usecase.Customers
{
    [Serializable]
    internal class DuplicatedCustomerException : Exception
    {
        public DuplicatedCustomerException(Guid id)
            : this(id, $"There is another customer with the same Id {id}.")
        {
        }

        public DuplicatedCustomerException(Guid id, string message)
            : base(message)
        {
            Id = id;
        }

        private Guid Id { get; }
    }
}