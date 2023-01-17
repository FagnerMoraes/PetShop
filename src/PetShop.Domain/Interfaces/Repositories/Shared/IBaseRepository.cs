using System.Linq.Expressions;
using PetShop.Domain.Entities.Shared;

namespace PetShop.Domain.Interfaces.Repositories.Shared;
public interface IBaseRepository<T> where T : Entity
{
    Task<IEnumerable<T>> GetAllAsync(Expression<Func<T>> filter = null);
    Task<T> GetByIdAsync(int id);
    Task CreateAsync(T entity);
    Task DeleteAsync(T entity);
    Task UpdateAsync(T entity);
}