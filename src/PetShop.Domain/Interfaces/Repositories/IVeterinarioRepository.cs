using PetShop.Domain.Entities;

namespace PetShop.Domain.Interfaces.Repositories
{
    public interface IVeterinarioRepository
    {
        Task<IEnumerable<Veterinario>> ObterTodosAsync();
        Task AdicionarAsync(Veterinario veterinario);
        void Atualizar(Veterinario veterinario);
        Task DeletarAsync(int id);
    }
}