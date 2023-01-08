
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Domain.Entities;

namespace PetShop.Data.Configuration;

public class VeterinarioConfiguration : IEntityTypeConfiguration<Veterinario>
{
    public void Configure(EntityTypeBuilder<Veterinario> builder)
    {
        builder.ToTable("veterinario");

        builder.OwnsOne(x => x.Nome)
            .Property(p => p.PrimeiroNome)
            .HasColumnName("primeiro_nome")
            .IsRequired()
            .HasMaxLength(15);

        builder.OwnsOne(x => x.Nome)
            .Property(p => p.Sobrenome)
            .HasColumnName("sobrenome")
            .IsRequired()
            .HasMaxLength(100);
    }
}
