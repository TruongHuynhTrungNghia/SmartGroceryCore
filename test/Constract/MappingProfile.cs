using AutoMapper;
using System;
using usecase.Customers;
using usecase.DAL;
using usecase.Product;

namespace test.Constract
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ProductDto, Product>()
                .ReverseMap()
                .ForPath(dest => dest.Id, opt => opt.Ignore());

            CreateMap<Customer, CreateCustomerCommand>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()))
                .ReverseMap();

            CreateMap<Product, CreateProductCommand>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => Guid.NewGuid()));
        }
    }
}