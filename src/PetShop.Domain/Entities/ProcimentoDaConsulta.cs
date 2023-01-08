using PetShop.Domain.Entities.Shared;
namespace PetShop.Domain.Entities;

public class ProcimentoDaConsulta : Entity
{
    public int ProcedimentoId { get; private set; }
    public int ConsultaId { get; private set; }
    public DateTime DataCriacao { get; private set; }

    protected ProcimentoDaConsulta(){}
    public ProcimentoDaConsulta(int id, int procedimentoId, int consultaId, DateTime dataCriacao)
    {
        Id = id;
        ProcedimentoId = procedimentoId;
        ConsultaId = consultaId;
        DataCriacao = dataCriacao;
    }

    public ProcimentoDaConsulta(int procedimentoId, int consultaId)
    : this(default,procedimentoId,consultaId,DateTime.Now) { }
}