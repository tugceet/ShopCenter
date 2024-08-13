using ShopCenter.Application.CQRS.Comands.AdminCommands;
using ShopCenter.Application.Interfaces;
using ShopCenter.Domain.Entities;
using System.Runtime.CompilerServices;

namespace ShopCenter.Application.CQRS.Handlers.AdminHandlers
{
    public class RemoveAdminCommandHandler
    {
        private readonly IRepository<Admin> _repository;

        public RemoveAdminCommandHandler(IRepository<Admin> repository)
        {
            _repository = repository;
        }
        public async Task Handle(RemoveAdminCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
