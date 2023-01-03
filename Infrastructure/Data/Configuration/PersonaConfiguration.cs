using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configuration;

public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
{
    public void Configure(EntityTypeBuilder<Persona> builder)
    {
        builder.ToTable("PERSONA");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).HasColumnName("ID_PERSONA")
                .IsRequired();

        builder.Property(p => p.Nombre)
                .HasMaxLength(50).HasColumnName("NOMBRE");

        builder.Property(p => p.Apellido)
                .HasMaxLength(50).HasColumnName("APELLIDO");

        builder.Property(p => p.NombreCompleto)
                .HasMaxLength(100).HasColumnName("NOMBRE_COMPLETO");

        builder.Property(p => p.TipoIdentificacion)
                .HasMaxLength(50).HasColumnName("TIPO_IDENTIFICACION");

        builder.Property(p => p.NumeroIdentificacion)
                .HasMaxLength(50).HasColumnName("NUMERO_IDENTIFICACION");

        builder.Property(p => p.NumeroIdentificacionTipo)
                .HasMaxLength(100).HasColumnName("NUMERO_IDENTIFICACION_TIPO");

        builder.Property(p => p.Email)
                .HasMaxLength(50).HasColumnName("EMAIL");

        builder.Property(p => p.FechaCreacion)
                .HasColumnType("datetime").HasColumnName("FECHA_CREACION");

    }
}
