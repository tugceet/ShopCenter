using ShopCenter.Application.CQRS.Comands.AdminCommands;
using ShopCenter.Application.Interfaces;
using ShopCenter.Domain.Entities;

namespace ShopCenter.Application.CQRS.Handlers.AdminHandlers
{
    public class CreateAdminCommandHandler
    {
        private readonly IRepository<Admin> _repository;

        public CreateAdminCommandHandler(IRepository<Admin> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateAdminCommand command)
        {
            await _repository.CreateAsync(new Admin
            {
                Password = command.Password,
                UserName = command.UserName
            });
        }
    }
}
