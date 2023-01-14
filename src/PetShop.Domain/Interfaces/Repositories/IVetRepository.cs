using PetShop.Domain.Entities;

namespace PetShop.Domain.Interfaces.Repositories
{
    public interface IVetRepository
    {
        Task<IEnumerable<Vet>> ObterTodosAsync();
        Task AdicionarAsync(Vet veterinario);
        void Atualizar(Vet veterinario);
        Task DeletarAsync(int id);
    }
}