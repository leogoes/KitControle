using Kit.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kit.Infra.Maps
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            
            builder.HasKey(p => p.IdUsuario);

            builder.Property(p => p.IdUsuario);
            builder.Property(p => p.NomeLogin);
            builder.Property(p => p.NomeUsuario);
            builder.Property(p => p.CodigoCarteira);
            builder.Property(p => p.Senha);
            builder.Property(p => p.TipoUsuario);

        }
    }
}
