using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using model;
using System.Linq;
using usecase.DAL;

namespace usecase.Customers
{
    public class GetCustomerByIdQueryHandler : RequestHandler<GetCustomerByIdQuery, CustomerDto>
    {
        private readonly IMapper mapper;
        private readonly TestDbContext context;

        public GetCustomerByIdQueryHandler(IMapper mapper, TestDbContext context)
        {
            this.mapper = mapper;
            this.context = context;
        }

        protected override CustomerDto Handle(GetCustomerByIdQuery query)
        {
            var customer = context.Set<Customer>()
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == query.Id);

            if (customer == null)
            {
                throw new CustomerNotFoundException(query.Id);
            }

            return mapper.Map<CustomerDto>(customer);
        }
    }
}