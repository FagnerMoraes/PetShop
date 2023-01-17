using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using PetShop.Data.Context;
using PetShop.Domain.Entities.Shared;
using PetShop.Domain.Interfaces.Repositories.Shared;

namespace PetShop.Data.Repositories.Shared
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        public readonly DbSet<T> _DbSet;
        public readonly PSContext _context;

        public BaseRepository(PSContext context)
        {
            _DbSet = context.Set<T>();
            _context = context;
        }

        public Task<IEnumerable<T>> GetAllAsync(Expression<Func<T>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }
       

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}