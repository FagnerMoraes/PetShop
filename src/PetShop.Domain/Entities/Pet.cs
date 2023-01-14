using PetShop.Domain.Entities.Shared;

namespace PetShop.Domain.Entities
{
    public class Pet: Entity
    {
        public int PetOwnerId { get; private set; }
        public string Name { get; private set; }
        public PetOwner? PetOwner { get; }

        public ICollection<VetCare> VetCares { get;}

        protected Pet() { }
        public Pet(int petOwnerId, string name)
            : this(default, petOwnerId, name) {
                Status = true;
                CreatedAt = DateTime.Now;
        }
        public Pet(int id, int petOwnerId, string name)
        {
            Id = id;
            PetOwnerId = petOwnerId;
            Name = name;
        }

    }
}