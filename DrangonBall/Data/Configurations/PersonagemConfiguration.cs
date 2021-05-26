using DrangonBall.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrangonBall.Data.Configurations {
    class PersonagemConfiguration : IEntityTypeConfiguration<Personagem> {
        public void Configure(EntityTypeBuilder<Personagem> builder) {
            builder.ToTable("Personagem");
            builder.HasKey(p => p.PersonagemId);
            builder.Property(p => p.Nome);
            builder.Property(p => p.PowerLevel).HasColumnType("");
        }
    }
}
