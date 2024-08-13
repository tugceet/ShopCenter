using ShopCenter.Application.CQRS.Comands.AdminCommands;
using ShopCenter.Application.Interfaces;
using ShopCenter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter.Application.CQRS.Handlers.AdminHandlers
{
    public class UpdateAdminCommandHandler
    {
        private readonly IRepository<Admin> _repository;

        public UpdateAdminCommandHandler(IRepository<Admin> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateAdminCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            values.UserName = command.UserName;
            values.Password = command.Password;
            values.CreatedDate = command.CreatedDate;
            await _repository.UpdateAsync(values);
        }
    }
}
