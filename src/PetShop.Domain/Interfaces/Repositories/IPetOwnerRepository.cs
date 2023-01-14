using PetShop.Domain.Entities;

namespace PetShop.Domain.Interfaces.Repositories;

public interface IPetOwnerRepository
{
    Task<IEnumerable<PetOwner>> GeAllAsync();
    Task<IEnumerable<PetOwner?>> GetByNameAsync(string name);
    Task CreateAsync(PetOwner petOwner);
    Task UpdateAsync(PetOwner petOwner);
}