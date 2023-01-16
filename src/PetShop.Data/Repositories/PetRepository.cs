using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PetShop.Data.Context;
using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;

namespace PetShop.Data.Repositories
{
    public class PetRepository : IPetRepository
    {
        private readonly PSContext _context;

        public PetRepository(PSContext context)
        {
            _context = context;
        }

        public Task CreateAsync(Pet pet)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pet>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Pet pet)
        {
            throw new NotImplementedException();
        }
    }
}