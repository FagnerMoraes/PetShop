using PetShop.Domain.Entities.Shared;
using PetShop.Domain.ValueObjects;

namespace PetShop.Domain.Entities;
public class PetOwner : Entity
{
    public Name Name { get; private set; }
    public string CellPhone { get; private set; }
    public Adress Adress { get; private set; }

    public ICollection<Pet> Pets {get;}

    protected PetOwner(){ }

    public PetOwner(int id, Name name, string cellPhone, Adress adress)
    {
        Id = id;
        Name = name;
        CellPhone = cellPhone;
        Adress = adress;
    }

    public PetOwner(Name name, string cellPhone, Adress adress)
            : this(default, name, cellPhone, adress) {
        Status = true;
        CreatedAt = DateTime.Now;
    }

}