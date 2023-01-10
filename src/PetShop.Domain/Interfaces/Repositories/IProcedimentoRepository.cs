using PetShop.Domain.Entities;
namespace PetShop.Domain.Interfaces.Repositories
{
    public interface IProcedimentoRepository
    {
        Task<IEnumerable<Procedimento>> ObterTodosAsync();
        Task AdicionarAsync(Procedimento procedimento);
        void Atualizar(Procedimento procedimento);
        Task DeletarAsync(int id);
    }
}