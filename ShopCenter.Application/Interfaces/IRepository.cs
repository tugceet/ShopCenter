using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsyncint();
        Task <T>  GetByIdAsync(int id );
        Task CreateAsync ( T entity );
        Task UpdateAsync ( T entity );
        Task RemoveAsync ( int id );
    }
}
