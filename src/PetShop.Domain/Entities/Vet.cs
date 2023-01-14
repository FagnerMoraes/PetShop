using PetShop.Domain.Entities.Shared;
using PetShop.Domain.ValueObjects;

namespace PetShop.Domain.Entities;
 public class Vet : Entity
 {
    public Name Name { get; private set; }
    public ICollection<VetCare> VetCares { get;}

    protected Vet(){}
    public Vet(Name name) : this(default,name) {
        Status = true;
        CreatedAt = DateTime.Now;
    }
    public Vet(int id, Name name)
    {
        Id = id;
        Name = name;
    }

 }
