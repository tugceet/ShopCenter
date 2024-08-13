using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ShopCenter.Application.CQRS.Comands.AdminCommands;
using ShopCenter.Application.CQRS.Handlers.AdminHandlers;
using ShopCenter.Application.CQRS.Queries;

namespace ShopCenter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminsController : ControllerBase
    {
        private readonly CreateAdminCommandHandler _createAdminCommandHandler;
        private readonly GetAdminByIdQueryHandler _getAdminByIdQueryHandler;
        private readonly GetAdminQueryHandler _getAdminQueryHandler;
        private readonly UpdateAdminCommandHandler _updateAdminCommandHandler;
        private readonly RemoveAdminCommandHandler _removeAdminCommandHandler;

        public AdminsController(CreateAdminCommandHandler createAdminCommandHandler, GetAdminByIdQueryHandler getAdminByIdQueryHandler, GetAdminQueryHandler getAdminQueryHandler, UpdateAdminCommandHandler updateAdminCommandHandler, RemoveAdminCommandHandler removeAdminCommandHandler)
        {
            _createAdminCommandHandler = createAdminCommandHandler;
            _getAdminByIdQueryHandler = getAdminByIdQueryHandler;
            _getAdminQueryHandler = getAdminQueryHandler;
            _updateAdminCommandHandler = updateAdminCommandHandler;
            _removeAdminCommandHandler = removeAdminCommandHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AdminList()
        {
            var values = await _getAdminQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdmin(Guid id)
        { 
            var values = await _getAdminByIdQueryHandler.Handle( new GetAdminByIdQuery(id));
            return Ok(values);
        }

        [HttpPost]
        
        public async Task<IActionResult> CreateAdmin(CreateAdminCommand command)
        {
            await _createAdminCommandHandler.Handle( command );
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAdmin(Guid id)
        {
            await _removeAdminCommandHandler.Handle( new RemoveAdminCommand(id));

            return Ok(); 
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAdmin(UpdateAdminCommand command)

        {
            await _updateAdminCommandHandler.Handle( command );
            return Ok();
        }
    }
}
