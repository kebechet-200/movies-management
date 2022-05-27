using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MoviesManagement.Domain.POCO;

namespace MoviesManagement.PersistanceDB.Configuration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {

            builder.HasKey(x => x.Id);

            builder.Property(x => x.State).IsRequired();

            builder.HasOne(t => t.Movie).WithMany(m => m.Tickets)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(t => t.MovieId);

            builder.HasOne(t => t.User).WithMany(u => u.Tickets)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(t => t.UserId);
        }
    }
}
