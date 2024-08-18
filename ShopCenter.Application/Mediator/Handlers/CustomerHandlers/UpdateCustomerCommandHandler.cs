using MediatR;
using ShopCenter.Application.Interfaces;
using ShopCenter.Application.Mediator.Commands.CustomerCommands;
using ShopCenter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter.Application.Mediator.Handlers.CustomerHandlers
{
    public class UpdateCustomerCommandHandler : IRequestHandler<UpdateCustomerCommand>
    {
        private readonly IRepository<Customer> _repository;

        public UpdateCustomerCommandHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            values.Name = request.Name;
            values.Email = request.Email;
            values.SurName = request.SurName;
            values.PhoneNumber = request.PhoneNumber;
            values.Address = request.Address;
            values.CreatedDate = request.CreatedDate;

            await _repository.UpdateAsync(values);
            
        }
    }
}
