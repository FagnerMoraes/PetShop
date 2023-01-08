using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;
using PetShop.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Data.Repositories
{
    public class DonoRepository : IDonoRepository
    {
        private readonly PSContext _context;

        public DonoRepository(PSContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Dono>> ObterTodosAsync() 
        => await _context.Donos.AsNoTracking().ToListAsync(); 
    }
}