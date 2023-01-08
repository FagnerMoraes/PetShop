using PetShop.Domain.Entities.Shared;

namespace PetShop.Domain.Entities;

public class Procedimento : Entity
{

    public string NomeProcedimento { get; private set; }
    public decimal ValorProcedimento { get; private set; }

    public ICollection<ProcimentoDaConsulta> ProcedimentosDasConsultas {get; set;}

    protected Procedimento() { }
    public Procedimento(string nomeProcedimento, decimal valorProcedimento) :
        this(default, nomeProcedimento, valorProcedimento) { }
    public Procedimento(int id, string nomeProcedimento, decimal valorProcedimento)
    {
        Id = id;
        NomeProcedimento = nomeProcedimento;
        ValorProcedimento = valorProcedimento;
    }
}