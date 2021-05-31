using DragonBall.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DragonBall.Data.Configurations
{
    public class PersonagemConfiguration : IEntityTypeConfiguration<Personagem>
    {
        public void Configure(EntityTypeBuilder<Personagem> builder)
        {
            builder.ToTable("Personagem");
            builder.Property(p => p.Nome).IsRequired();
            builder.Property(p => p.PowerLevel).IsRequired();
        }
    }
}
