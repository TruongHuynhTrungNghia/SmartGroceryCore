using AutoMapper;
using model;
using usecase.DAL;

namespace usecase.Customers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<CreateCustomerCommand, Customer>();
        }
    }
}