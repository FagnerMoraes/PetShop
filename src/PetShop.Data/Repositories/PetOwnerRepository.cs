using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;
using PetShop.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Data.Repositories
{
    public class PetOwnerRepository : IPetOwnerRepository
    {
        private readonly PSContext _context;
        public PetOwnerRepository(PSContext context) {  _context = context; }

        public async Task CreateAsync(PetOwner petOwner) {
            await _context.PetOwners.AddAsync(petOwner);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(PetOwner petOwner) {
            _context.Entry(petOwner).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public Task DeletarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PetOwner?>> GetByNameAsync(string name)
        => await _context.PetOwners
                .Where(x => string.Concat(x.Name.FirstName," ", x.Name.LastName)
                .Contains(name)).AsNoTracking().ToListAsync();

        public async Task<IEnumerable<PetOwner>> GeAllAsync() 
        => await _context.PetOwners.AsNoTracking().ToListAsync(); 
    }
}