using AutoMapper;

namespace usecase.Product
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateProductCommand, model.Product>();
        }
    }
}