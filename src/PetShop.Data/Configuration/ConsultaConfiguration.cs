using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShop.Domain.Entities;

namespace PetShop.Data.Configuration
{
    public class ConsultaConfiguration : IEntityTypeConfiguration<Consulta>
    {
        
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("consulta");
            
            builder.Property(x => x.DataConsulta)
                .HasColumnName("data_consulta")
                .HasColumnType("date");
            
            builder.Property(x => x.HorarioConsulta)
                .HasColumnName("hora_consulta")
                .HasColumnType("time");
        }
    }
}