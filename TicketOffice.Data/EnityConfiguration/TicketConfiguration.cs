using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketOffice.Data.Entities;

namespace TicketOffice.Data.EnityConfiguration
{
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .HasOne(x=>x.Passanger)
                .WithMany(x=>x.Tickets)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
