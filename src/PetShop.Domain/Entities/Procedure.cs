using PetShop.Domain.Entities.Shared;

namespace PetShop.Domain.Entities;

public class Procedure : Entity
{

    public string ProcedureName { get; private set; }
    public decimal ProcedureValue { get; private set; }

    public ICollection<CareProcedure> CareProcedures { get;}

    protected Procedure() { }
    public Procedure(string procedureName, decimal procedureValue) :
        this(default, procedureName, procedureValue) {
            Status = true;
            CreatedAt = DateTime.Now;
    }
    public Procedure(int id, string procedureName, decimal procedureValue)
    {
        Id = id;
        ProcedureName = procedureName;
        ProcedureValue = procedureValue;
    }
}