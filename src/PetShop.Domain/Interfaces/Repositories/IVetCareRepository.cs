
using PetShop.Domain.Entities;

namespace PetShop.Domain.Interfaces.Repositories
{
    public interface IVetCareRepository
    {
        Task<VetCare?> GetByVetCareDateAsync(DateTime vetCareDate);
        Task CreateAsync(VetCare vetCare);
        Task UpdateAsync(VetCare vetCare);
    }
}