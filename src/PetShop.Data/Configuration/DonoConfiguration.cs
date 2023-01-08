using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Domain.Entities;

namespace PetShop.Data.Configuration;

public class DonoConfiguration : IEntityTypeConfiguration<Dono>
{
    public void Configure(EntityTypeBuilder<Dono> builder)
    {
        builder.ToTable("dono");

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

        builder.Property(x => x.Telefone)
            .HasColumnName("telefone")
            .IsRequired()
            .HasMaxLength(11);

        builder.OwnsOne(x => x.Endereco)
            .Property(p => p.Rua)
            .HasColumnName("rua_endereco")
            .IsRequired();
        
        builder.OwnsOne(x => x.Endereco)
            .Property(p => p.Bairro)
            .HasColumnName("bairro_endereco")
            .IsRequired();
        
        builder.OwnsOne(x => x.Endereco)
            .Property(p => p.Numero)
            .HasColumnName("numero_endereco")
            .IsRequired();
        
        builder.OwnsOne(x => x.Endereco)
            .Property(p => p.Cep)
            .HasColumnName("cep_endereco")
            .IsRequired();
        
    }
}