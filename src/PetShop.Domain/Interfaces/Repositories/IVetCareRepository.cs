
using PetShop.Domain.Entities;

namespace PetShop.Domain.Interfaces.Repositories
{
    public interface IVetCareRepository
    {
        Task<VetCare?> ObterPorDataConsultaAsync(DateTime dataConsulta);
        Task AdicionarAsync(VetCare consulta);
        void Atualizar(VetCare consulta);
        Task DeletarAsync(int id);
    }
}