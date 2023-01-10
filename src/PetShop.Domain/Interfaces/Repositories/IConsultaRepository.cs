
using PetShop.Domain.Entities;

namespace PetShop.Domain.Interfaces.Repositories
{
    public interface IConsultaRepository
    {
        Task<Consulta?> ObterPorDataConsultaAsync(DateTime dataConsulta);
        Task AdicionarAsync(Consulta consulta);
        void Atualizar(Consulta consulta);
        Task DeletarAsync(int id);
    }
}