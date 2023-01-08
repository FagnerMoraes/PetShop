
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Domain.Entities;

namespace PetShop.Data.Configuration;

public class ProcedimentoConfiguration : IEntityTypeConfiguration<Procedimento>
{
    public void Configure(EntityTypeBuilder<Procedimento> builder)
    {
        builder.ToTable("procedimento");

        builder.Property(x => x.NomeProcedimento)
            .HasColumnName("nome_procedimento")
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.NomeProcedimento)
            .HasColumnName("valor_procedimento")
            .IsRequired()
            .HasPrecision(18, 2);


    }
}
