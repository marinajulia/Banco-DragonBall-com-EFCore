using DragonBall.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBall.Data.Configurations {
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario> {
        public void Configure(EntityTypeBuilder<Usuario> builder) {
            builder.ToTable("User");
            builder.HasKey(p => p.UserId);
            builder.Property(p => p.UserName).IsRequired();
            builder.Property(p => p.Senha).IsRequired();
            builder.Property(p => p.Role);
        }
    }
}
