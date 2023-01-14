using PetShop.Data.Context;
using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;

namespace PetShop.Data.Repositories;

public class ProcedureRepository : IProcedureRepository
{
    private readonly PSContext _context;

    public ProcedureRepository(PSContext context)
    {
        _context = context;
    }

    public Task AdicionarAsync(Procedure procedimento)
    {
        throw new NotImplementedException();
    }

    public void Atualizar(Procedure procedimento)
    {
        throw new NotImplementedException();
    }

    public Task DeletarAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Procedure>> ObterTodosAsync()
    {
        throw new NotImplementedException();
    }
}