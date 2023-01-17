using PetShop.Domain.Entities;

namespace PetShop.Domain.Interfaces.Repositories;

public interface IPetOwnerRepository : IDisposable
{
    Task<IEnumerable<PetOwner>> GeAllAsync();
    Task<PetOwner?> GetByIdAsync(int id);
    Task<IEnumerable<PetOwner?>> GetByNameAsync(string name);
    Task CreateAsync(PetOwner petOwner);
    void UpdateAsync(PetOwner petOwner);
    Task<bool> SaveAsync();
}