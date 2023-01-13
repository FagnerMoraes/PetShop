using PetShop.Domain.Entities.Shared;
using PetShop.Domain.ValueObjects;

namespace PetShop.Domain.Entities;
 public class Veterinario : Entity
 {
    public Nome Nome { get; private set; }
    public ICollection<Consulta> Consultas {get; set;}

    protected Veterinario(){}
    public Veterinario(Nome nome) : this(default,nome) {
        Status = true;
     }
    public Veterinario(int id, Nome nome)
    {
        Id = id;
        Nome = nome;
    }

 }
