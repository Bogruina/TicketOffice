using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TicketOffice.Data.Entities;

namespace TicketOffice.Data.EnityConfiguration
{
    public class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .HasOne(x => x.Flight)
                .WithOne(x => x.Plane)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
