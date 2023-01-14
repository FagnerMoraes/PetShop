using PetShop.Domain.Entities;
namespace PetShop.Domain.Interfaces.Repositories
{
    public interface IProcedureRepository
    {
        Task<IEnumerable<Procedure>> ObterTodosAsync();
        Task AdicionarAsync(Procedure procedimento);
        void Atualizar(Procedure procedimento);
        Task DeletarAsync(int id);
    }
}