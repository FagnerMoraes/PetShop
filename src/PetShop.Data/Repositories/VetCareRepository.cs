using PetShop.Data.Context;
using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;

namespace PetShop.Data.Repositories;

public class VetCareRepository : IVetCareRepository
{
    private readonly PSContext _context;

    public VetCareRepository(PSContext context)
    {
        _context = context;
    }

    

}