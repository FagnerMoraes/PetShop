using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Data.Context;
using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;

namespace PetShop.Data.Repositories;

public class VetRepository : IVetRepository
{
    private readonly PSContext _context;

    public VetRepository(PSContext context)
    {
        _context = context;
    }

    public Task AdicionarAsync(Vet veterinario)
    {
        throw new NotImplementedException();
    }

    public void Atualizar(Vet veterinario)
    {
        throw new NotImplementedException();
    }

    public Task DeletarAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Vet>> ObterTodosAsync()
    {
        throw new NotImplementedException();
    }
}