using PetShop.Domain.Entities.Shared;

namespace PetShop.Domain.Entities;

public class VetCare : Entity
{
    public int PetId { get; private set; }
    public int VetId { get; private set; }
    public DateTime CareProcedureDate { get; private set; }
    public TimeSpan CareProcedureTime { get; private set; }

    public Pet? Pet{get;}
    public Vet? Veterinario{get;}

    public ICollection<CareProcedure> ProcedimentosDasConsultas {get; set;}

    protected VetCare() { }
    
    public VetCare(int id,int petId, int vetId, DateTime careProcedureDate, TimeSpan careProcedureTime)
    {
        Id= id; 
        PetId = petId;
        VetId = vetId;
        CareProcedureDate = careProcedureDate;
        CareProcedureTime = careProcedureTime;
    }

    public VetCare(int petId, int veterinarioId, DateTime dataConsulta, TimeSpan horarioConsulta) :
            this(default,petId,veterinarioId,dataConsulta,horarioConsulta) { 
                Status = true;
                CreatedAt = DateTime.Now;
    }


}