using MediatR;
using ShopCenter.Application.Interfaces;
using ShopCenter.Application.Mediator.Queries.CustomerQueries;
using ShopCenter.Application.Mediator.Results.CustomerResults;
using ShopCenter.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter.Application.Mediator.Handlers.CustomerHandlers
{
    public class GetCustomerByIdQueryHandler : IRequestHandler<GetCustomerByIdQuery, GetCustomerByIdQueryResult>
    {
        private readonly IRepository<Customer> _repository;

        public GetCustomerByIdQueryHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<GetCustomerByIdQueryResult> Handle(GetCustomerByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetCustomerByIdQueryResult
            {
                Address = values.Address,
                Email = values.Email,
                Name = values.Name,
                PhoneNumber = values.PhoneNumber,
                SurName = values.SurName
               
            };
        }
    }
}
