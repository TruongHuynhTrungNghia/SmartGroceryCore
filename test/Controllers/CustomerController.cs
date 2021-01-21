using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading;
using System.Threading.Tasks;
using test.Constract;
using usecase.Customers;

namespace test.Controllers
{
    [ApiController]
    [Route("customers")]
    public class CustomerController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IMediator mediator;

        public CustomerController(IMapper mapper, IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(Customer customer, CancellationToken cancellation)
        {
            var request = mapper.Map<CreateCustomerCommand>(customer);
            var result = await mediator.Send(request, cancellation);

            return Ok(result);
        }
    }
}