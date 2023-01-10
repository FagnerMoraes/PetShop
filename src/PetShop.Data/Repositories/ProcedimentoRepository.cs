using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Data.Context;
using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;

namespace PetShop.Data.Repositories
{
    public class ProcedimentoRepository : IProcedimentoRepository
    {
        private readonly PSContext _context;

        public ProcedimentoRepository(PSContext context)
        {
            _context = context;
        }

        public Task AdicionarAsync(Procedimento procedimento)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Procedimento procedimento)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Procedimento>> ObterTodosAsync()
        {
            throw new NotImplementedException();
        }
    }
}