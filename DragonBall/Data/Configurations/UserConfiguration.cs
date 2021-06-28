using DragonBall.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonBall.Data.Configurations {
    public class UserConfiguration : IEntityTypeConfiguration<User> {
        public void Configure(EntityTypeBuilder<User> builder) {
            builder.ToTable("User");
            builder.HasKey(p => p.UserId);
            builder.Property(p => p.UserName).IsRequired();
            builder.Property(p => p.Password).IsRequired();
        }
    }
}
