using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Domain.Entities;

namespace PetShop.Data.Configuration;

public class PetOwnerConfiguration : IEntityTypeConfiguration<PetOwner>
{
    public void Configure(EntityTypeBuilder<PetOwner> builder)
    {
        builder.ToTable("pet_owner");

        builder.OwnsOne(x => x.Name)
            .Property(p => p.FirstName)
            .HasColumnName("primeiro_nome")
            .IsRequired()
            .HasMaxLength(15);

        builder.OwnsOne(x => x.Name)
            .Property(p => p.LastName)
            .HasColumnName("sobrenome")
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.Telefone)
            .HasColumnName("telefone")
            .IsRequired()
            .HasMaxLength(11);

        builder.OwnsOne(x => x.Endereco)
            .Property(p => p.Street)
            .HasColumnName("rua_endereco")
            .IsRequired();
        
        builder.OwnsOne(x => x.Endereco)
            .Property(p => p.District)
            .HasColumnName("bairro_endereco")
            .IsRequired();
        
        builder.OwnsOne(x => x.Endereco)
            .Property(p => p.HouseNumber)
            .HasColumnName("numero_endereco")
            .IsRequired();
        
        builder.OwnsOne(x => x.Endereco)
            .Property(p => p.ZipCode)
            .HasColumnName("cep_endereco")
            .IsRequired();
        
    }
}