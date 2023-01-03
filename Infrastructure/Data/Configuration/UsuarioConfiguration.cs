using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Configuration;

public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("USUARIO");

        builder.Property(p => p.Id).HasColumnName("ID_USUARIO")
            .IsRequired();
        builder.HasKey(p => p.Id);

        builder.Property(p => p.UserName).HasColumnName("USUARIO")
            .HasMaxLength(50);

        builder.Property(p => p.Pass)
            .HasMaxLength(100).HasColumnName("PASS");


        builder.Property(p => p.FechaCreacion)
            .HasColumnType("datetime").HasColumnName("FECHA_CREACION");
        
    }
}
