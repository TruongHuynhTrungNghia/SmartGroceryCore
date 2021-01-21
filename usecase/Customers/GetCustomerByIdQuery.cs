using System;
using MediatR;
using usecase.DAL;

namespace usecase.Customers
{
    public class GetCustomerByIdQuery : IRequest<CustomerDto>
    {
        public Guid Id { get; set; }
    }
}
