using DrangonBall.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrangonBall.Data.Configurations {
    public class ClasseConfiguration : IEntityTypeConfiguration<Classe> {
        public void Configure(EntityTypeBuilder<Classe> builder) {
            builder.ToTable("Classe");
            builder.HasKey(p => p.ClasseId);
            builder.Property(p => p.Descricao).HasColumnType("VARCHAR(600)");
        }
    }
}
