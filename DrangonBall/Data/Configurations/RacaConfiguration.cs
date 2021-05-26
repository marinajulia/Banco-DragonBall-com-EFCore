using DrangonBall.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrangonBall.Data.Configurations {
    public class RacaConfiguration : IEntityTypeConfiguration<Raca> {
        public void Configure(EntityTypeBuilder<Raca> builder) {
            builder.ToTable("Raça");
            builder.HasKey(p => p.RacaId);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(100)");
        }
    }
}
