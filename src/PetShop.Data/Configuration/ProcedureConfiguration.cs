
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Domain.Entities;

namespace PetShop.Data.Configuration;

public class ProcedureConfiguration : IEntityTypeConfiguration<Procedure>
{
    public void Configure(EntityTypeBuilder<Procedure> builder)
    {
        builder.ToTable("procedimento");

        builder.Property(x => x.ProcedureName)
            .HasColumnName("nome_procedimento")
            .IsRequired()
            .HasMaxLength(200);

        builder.Property(x => x.ProcedureValue)
            .HasColumnName("valor_procedimento")
            .IsRequired()
            .HasPrecision(18, 2);


    }
}
