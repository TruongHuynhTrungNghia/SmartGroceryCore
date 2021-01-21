using MediatR;
using System;

namespace usecase.Customers
{
    public class CreateCustomerCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime DateofBirth { get; set; }
    }
}