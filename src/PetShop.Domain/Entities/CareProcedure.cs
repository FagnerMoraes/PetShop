using PetShop.Domain.Entities.Shared;
namespace PetShop.Domain.Entities;

public class CareProcedure : Entity
{
    public int ProcedureId { get; private set; }
    public int VetCareId { get; private set; }

    public Procedure? Procedure { get;}
    public VetCare? VetCare { get; }

    protected CareProcedure(){}
    public CareProcedure(int id, int procedureId, int vetCareId)
    {
        Id = id;
        ProcedureId = procedureId;
        VetCareId = vetCareId;
    }

    public CareProcedure(int procedureId, int vetCareId)
    : this(default, procedureId, vetCareId) {
        Status = true;
        CreatedAt = DateTime.Now;
     }
}