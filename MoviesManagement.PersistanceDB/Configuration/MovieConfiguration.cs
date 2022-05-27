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
            builder.HasIndex(x => x.Name).IsUnique();
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).IsRequired();
            builder.Property(x => x.Image);
            builder.Property(x => x.IsExpired).IsRequired();

            builder.Property(x => x.Description);

            builder.Property(x => x.StartDate).IsRequired().HasColumnType("datetime");

            builder.Property(x => x.IsActive).IsRequired();

            builder.HasMany(x => x.Tickets).WithOne(x => x.Movie);
        }
    }
}
