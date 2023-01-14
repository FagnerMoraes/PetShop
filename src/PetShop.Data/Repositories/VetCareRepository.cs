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

    public Task AdicionarAsync(VetCare consulta)
    {
        throw new NotImplementedException();
    }

    public void Atualizar(VetCare consulta)
    {
        throw new NotImplementedException();
    }

    public Task DeletarAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<VetCare?> ObterPorDataConsultaAsync(DateTime dataConsulta)
    {
        throw new NotImplementedException();
    }
}