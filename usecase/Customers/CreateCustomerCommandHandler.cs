using AutoMapper;
using MediatR;
using model;
using System;
using System.Linq;
using usecase.DAL;

namespace usecase.Customers
{
    public class CreateCustomerCommandHandler : RequestHandler<CreateCustomerCommand, Guid>
    {
        private readonly IMapper mapper;
        private readonly TestDbContext context;

        public CreateCustomerCommandHandler(IMapper mapper, TestDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        protected override Guid Handle(CreateCustomerCommand command)
        {
            var existingCustomer = context.Set<Customer>().FirstOrDefault(x => x.Id == command.Id);

            if (existingCustomer != null)
            {
                throw new DuplicatedCustomerException(command.Id);
            }

            var customer = mapper.Map<Customer>(command);

            context.Set<Customer>().Add(customer);
            context.SaveChanges();

            return customer.Id;
        }
    }
}