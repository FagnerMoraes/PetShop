using PetShop.Domain.Entities;

namespace PetShop.Domain.Interfaces.Repositories
{
    public interface IPetRepository
    {
        Task<IEnumerable<Pet>> ObterTodosAsync();

        Task AdicionarAsync(Pet pet);
        void Atualizar(Pet pet);
        Task DeletarAsync(int id);
    }
}
