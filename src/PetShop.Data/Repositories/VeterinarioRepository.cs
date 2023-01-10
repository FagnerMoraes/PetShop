using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Data.Context;
using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;

namespace PetShop.Data.Repositories
{
    public class VeterinarioRepository : IVeterinarioRepository
    {
        private readonly PSContext _context;

        public VeterinarioRepository(PSContext context)
        {
            _context = context;
        }

        public Task AdicionarAsync(Veterinario veterinario)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Veterinario veterinario)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Veterinario>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}