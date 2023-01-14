
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Domain.Entities;

namespace PetShop.Data.Configuration;

public class VetConfiguration : IEntityTypeConfiguration<Vet>
{
    public void Configure(EntityTypeBuilder<Vet> builder)
    {
        builder.ToTable("veterinario");

        builder.OwnsOne(x => x.Nome)
            .Property(p => p.FirstName)
            .HasColumnName("primeiro_nome")
            .IsRequired()
            .HasMaxLength(15);

        builder.OwnsOne(x => x.Nome)
            .Property(p => p.LastName)
            .HasColumnName("sobrenome")
            .IsRequired()
            .HasMaxLength(100);
    }
}
