using PetShop.Domain.Entities;
using PetShop.Domain.Interfaces.Repositories;
using PetShop.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Data.Repositories
{
    public class DonoRepository : IDonoRepository
    {
        private readonly PSContext _context;
        public DonoRepository(PSContext context) {  _context = context; }

        public async Task AdicionarAsync(Dono dono) {
            await _context.Donos.AddAsync(dono);
            await _context.SaveChangesAsync();
        }
        public async Task Atualizar(Dono dono) {
            _context.Entry(dono).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public Task DeletarAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Dono?>> ObterPorNome(string nomeDono)
        => await _context.Donos
                .Where(x => string.Concat(x.Nome.PrimeiroNome," ", x.Nome.Sobrenome)
                .Contains(nomeDono)).AsNoTracking().ToListAsync();

        public async Task<IEnumerable<Dono>> ObterTodosAsync() 
        => await _context.Donos.AsNoTracking().ToListAsync(); 
    }
}