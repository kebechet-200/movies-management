using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesManagement.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoviesManagement.PersistanceDB.Configuration
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Image).HasMaxLength(80);
            builder.Property(x => x.IsExpired).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(256);
            builder.Property(x => x.StartDate).IsRequired().HasColumnType("datetime");
            builder.Property(x => x.IsActive).IsRequired();
            // one to many
            builder.HasMany(x => x.Tickets).WithOne(x => x.Movie);
        }
    }
}
