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

        public DbSet<Consulta> Consultas {get; set;}
        public DbSet<Dono> Donos {get; set;}
        public DbSet<Pet> Pets {get; set;}
        public DbSet<Procedimento> Procedimentos {get; set;}
        public DbSet<ProcimentoDaConsulta> ProcedimentosDasConsultas {get; set;}
        public DbSet<Veterinario> Veterinarios {get; set;}
    }
}