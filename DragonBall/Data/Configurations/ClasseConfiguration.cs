using DragonBall.Models;
using Microsoft.EntityFrameworkCore;

namespace DragonBall.Data.Configurations
{
    public class ClasseConfiguration : IEntityTypeConfiguration<Classe>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Classe> builder)
        {
            builder.ToTable("Classe");
            builder.HasKey(p => p.ClasseId);
            builder.Property(p => p.DescricaoClasse);
        }
    }

}
