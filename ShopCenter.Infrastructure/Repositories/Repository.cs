using Microsoft.EntityFrameworkCore;
using ShopCenter.Application.Interfaces;
using ShopCenter.Infrastructure.Context;

namespace ShopCenter.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ShopCenterContext _context;

        public Repository(ShopCenterContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
           return await _context.Set<T>().ToListAsync();
        }

       

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
           _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
