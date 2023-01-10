using PetShop.Domain.Entities.Shared;

namespace PetShop.Domain.Entities;

public class Consulta : Entity
{
    public int PetId { get; private set; }
    public int VeterinarioId { get; private set; }
    public DateTime DataConsulta { get; private set; }
    public TimeSpan HorarioConsulta { get; private set; }

    public Pet Pet{get;}
    public Veterinario Veterinario{get;}

    public ICollection<ProcimentoDaConsulta> ProcedimentosDasConsultas {get; set;}

    protected Consulta() { }
    
    public Consulta(int id,int petId, int veterinarioId, DateTime dataConsulta, TimeSpan horarioConsulta)
    {
        Id= id; 
        PetId = petId;
        VeterinarioId = veterinarioId;
        DataConsulta = dataConsulta;
        HorarioConsulta = horarioConsulta;
    }

    public Consulta(int petId, int veterinarioId, DateTime dataConsulta, TimeSpan horarioConsulta) :
            this(default,petId,veterinarioId,dataConsulta,horarioConsulta) { }


}