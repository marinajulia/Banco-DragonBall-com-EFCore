using DragonBall.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DragonBall.Data.Configurations
{
    public class RacaConfiguration : IEntityTypeConfiguration<Raca>
    {
        public void Configure(EntityTypeBuilder<Raca> builder)
        {
            builder.ToTable("Raca");
            builder.HasKey(p => p.RacaId);
            builder.Property(p => p.Nome);
        }
    }
}
