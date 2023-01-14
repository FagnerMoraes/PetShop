using Microsoft.EntityFrameworkCore;
using PetShop.Domain.Entities;
using System.Reflection;

namespace PetShop.Data.Context
{
    public class PSContext : DbContext
    {
        public PSContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<VetCare> VetCares { get; set;}
        public DbSet<PetOwner> PetOwners { get; set;}
        public DbSet<Pet> Pets {get; set;}
        public DbSet<Procedure> Procedures { get; set;}
        public DbSet<CareProcedure> CareProcedures { get; set;}
        public DbSet<Vet> Vets { get; set;}
    }
}