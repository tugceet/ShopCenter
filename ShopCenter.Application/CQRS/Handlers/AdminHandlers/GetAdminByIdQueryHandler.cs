using ShopCenter.Application.CQRS.Queries;
using ShopCenter.Application.CQRS.Results.AdminResults;
using ShopCenter.Application.Interfaces;
using ShopCenter.Domain.Entities;

namespace ShopCenter.Application.CQRS.Handlers.AdminHandlers
{
    public class GetAdminByIdQueryHandler
    {
        private readonly IRepository<Admin> _repository;

        public GetAdminByIdQueryHandler(IRepository<Admin> repository)
        {
            _repository = repository;
        } 
        public async Task< GetAdminByIdQueryResult> Handle(GetAdminByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAdminByIdQueryResult
            {
                Password = values.Password,
                UserName = values.UserName
            };
        }
    }
}
