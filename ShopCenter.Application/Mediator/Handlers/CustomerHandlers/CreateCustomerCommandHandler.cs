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
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand>
    {
        private readonly IRepository<Customer> _repository;

        public CreateCustomerCommandHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {

            await _repository.CreateAsync(new Customer
            {
               PhoneNumber = request.PhoneNumber,
               SurName = request.SurName,
               Address = request.Address,
               Email = request.Email,
               Name = request.Name
               
            });

        }
    }
}
