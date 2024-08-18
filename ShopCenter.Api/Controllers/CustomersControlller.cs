using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopCenter.Application.Mediator.Commands.CustomerCommands;
using ShopCenter.Application.Mediator.Queries.CustomerQueries;

namespace ShopCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersControlller : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersControlller(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CustomerList()
        {
            var values = await _mediator.Send(new GetCustomerQuery()); // Send metodu Handlelara istekte bulunmak için kullanacagım metod 
            return Ok(values);
               
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(Guid id)
        {
            var value = await _mediator.Send(new GetCustomerByIdQuery( id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerCommand command )
        {
             await _mediator.Send(command); 
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveCustomer(Guid id)
        {
            await _mediator.Send(new RemoveCustomerCommand( id));
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCustomer(UpdateCustomerCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
