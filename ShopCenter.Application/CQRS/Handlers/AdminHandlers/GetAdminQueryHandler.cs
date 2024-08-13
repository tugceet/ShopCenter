using ShopCenter.Application.CQRS.Results.AdminResults;
using ShopCenter.Application.Interfaces;
using ShopCenter.Domain.Entities;

namespace ShopCenter.Application.CQRS.Handlers.AdminHandlers
{
    public class GetAdminQueryHandler
    {
        private readonly IRepository<Admin> _repository;

        public GetAdminQueryHandler(IRepository<Admin> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetAdminQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetAdminQueryResult
            {
               Password = x.Password,
               UserName= x.UserName
            }).ToList();
        }

    }
}
