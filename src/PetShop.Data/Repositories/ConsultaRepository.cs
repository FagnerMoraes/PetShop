using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Data.Context;
using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;

namespace PetShop.Data.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {
        private readonly PSContext _context;

        public ConsultaRepository(PSContext context)
        {
            _context = context;
        }

        public Task AdicionarAsync(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Consulta consulta)
        {
            throw new NotImplementedException();
        }

        public Task DeletarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Consulta?> ObterPorDataConsultaAsync(DateTime dataConsulta)
        {
            throw new NotImplementedException();
        }
    }
}