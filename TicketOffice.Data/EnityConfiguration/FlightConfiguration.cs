using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketOffice.Data.Entities;

namespace TicketOffice.Data.EnityConfiguration
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(x=>x.Id);
            builder
                .HasOne(x => x.Ticket)
                .WithOne(x => x.Flight)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
