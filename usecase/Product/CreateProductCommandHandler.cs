using AutoMapper;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using usecase.DAL;

namespace usecase.Product
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly TestDbContext context;
        private readonly IMapper mapper;

        public CreateProductCommandHandler(TestDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<Guid> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            var exsitingProduct = context.Set<model.Product>()
                .FirstOrDefault(x => x.Id == command.Id);

            if (exsitingProduct != null)
            {
                throw new DuplicatedProductException(command.Id);
            }

            var product = mapper.Map<model.Product>(command);

            context.Set<model.Product>().Add(product);
            await context.SaveChangesAsync();

            return product.Id;
        }
    }
}