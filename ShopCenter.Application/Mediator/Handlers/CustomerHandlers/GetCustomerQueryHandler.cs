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
    public class GetCustomerQueryHandler : IRequestHandler<GetCustomerQuery, List<GetCustomerQueryResult>> //istek ve yanıtın nereden yapılacağı yazılır.
    {
        private readonly IRepository<Customer> _repository;

        public GetCustomerQueryHandler(IRepository<Customer> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCustomerQueryResult>> Handle(GetCustomerQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCustomerQueryResult
            {
                 Name= x.Name,
                 Address= x.Address,
                 Email= x.Email,
                 PhoneNumber= x.PhoneNumber,
                 SurName= x.SurName
                 
            }).ToList();
        }
    }
}
