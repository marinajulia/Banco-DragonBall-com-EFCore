using DragonBall.Models;
using Microsoft.EntityFrameworkCore;

namespace DragonBall.Data.Configurations
{
    public class InfoRacaConfiguration : IEntityTypeConfiguration<InfoRaca>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<InfoRaca> builder)
        {
            builder.ToTable("InfoRaca");
            builder.HasKey(p => p.InfoRacaId);
            builder.Property(p => p.DescricaoInfoRaca).IsRequired();

        }
    }
}
