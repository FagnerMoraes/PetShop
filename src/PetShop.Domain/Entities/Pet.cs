using PetShop.Domain.Entities.Shared;

namespace PetShop.Domain.Entities
{
    public class Pet: Entity
    {
        public int DonoId { get; private set; }
        public string Nome { get; private set; }

        public Dono Dono { get; }

        public ICollection<Consulta> Consultas {get; set;}

        protected Pet() { }
        public Pet(int donoId, string nome)
            : this(default, donoId, nome) { }
        public Pet(int id, int donoId, string nome)
        {
            Id = id;
            DonoId = donoId;
            Nome = nome;
        }

    }
}