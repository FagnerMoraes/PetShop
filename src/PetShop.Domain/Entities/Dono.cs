using PetShop.Domain.Entities.Shared;
using PetShop.Domain.ValueObjects;

namespace PetShop.Domain.Entities;
public class Dono : Entity
{
    public Nome Nome { get; private set; }
    public string Telefone { get; private set; }
    public Endereco Endereco { get; private set; }

    public ICollection<Pet> Pets {get; set;}

    protected Dono(){ }

    public Dono(int id, Nome nome, string telefone, Endereco endereco)
    {
        Id = id;
        Nome = nome;
        Telefone = telefone;
        Endereco = endereco;
    }

    public Dono(Nome nome, string telefone, Endereco endereco)
            : this(default, nome, telefone, endereco) {
        Status = true;
    }

}