using PetShop.Domain.Entities.Shared;

namespace PetShop.Domain.Interfaces.Repositories.Shared;
public interface IBaseRepository<TEntity> : IDisposable where TEntity : Entity
{


}