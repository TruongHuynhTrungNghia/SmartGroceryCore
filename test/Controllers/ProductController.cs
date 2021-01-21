using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using test.Constract;
using usecase.Product;

namespace test.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public ProductController(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product product, CancellationToken cancellationToken)
        {
            var request = mapper.Map<CreateProductCommand>(product);
            var result = await mediator.Send(request, cancellationToken);

            return Ok(result);
        }
    }
}