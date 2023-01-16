using PetShop.Domain.Entities;

namespace PetShop.Domain.Interfaces.Repositories
{
    public interface IPetRepository
    {
        Task<IEnumerable<Pet>> GetAllAsync();
        Task CreateAsync(Pet pet);
        Task UpdateAsync(Pet pet);
    }
}
