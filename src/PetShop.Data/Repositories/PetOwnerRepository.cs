using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;
using PetShop.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace PetShop.Data.Repositories
{
    public class PetOwnerRepository : IPetOwnerRepository
    {
        private readonly PSContext _context;
        public PetOwnerRepository(PSContext context) {  _context = context; }

        public async Task CreateAsync(PetOwner petOwner) 
            =>  await _context.PetOwners.AddAsync(petOwner);
        
        public void UpdateAsync(PetOwner petOwner) 
            => _context.Entry(petOwner).State = EntityState.Modified;

        public async Task<IEnumerable<PetOwner?>> GetByNameAsync(string name) 
            => await _context.PetOwners
                .Where(x => string.Concat(x.Name.FirstName," ", x.Name.LastName)
                .Contains(name)).AsNoTracking().ToListAsync();

        public async Task<IEnumerable<PetOwner>> GeAllAsync() 
            => await _context.PetOwners
                .AsNoTracking().ToListAsync();

        public async Task<PetOwner?> GetByIdAsync(int id)
            => await _context.PetOwners
                .AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);

        public async Task<bool> SaveAsync() 
            => await _context.SaveChangesAsync() > 0;

        public void Dispose() 
            => _context.Dispose();
    }
}