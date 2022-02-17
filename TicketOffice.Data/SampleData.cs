using TicketOffice.Data.Entities;

namespace TicketOffice.Data
{
    public static class SampleData
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();
            if (!context.Planes.Any())
            {
                context.Planes.AddRange(
                    new Plane
                    {
                        Model = "ИЛ 76",
                        Capacity = 200,
                        Manufacturer = "Звезда",
                        MaxSpeed = 2000
                    },
                    new Plane
                    {
                        Model = "757",
                        Capacity = 350,
                        Manufacturer = "Boeing",
                        MaxSpeed = 2500
                    },
                    new Plane
                    {
                        Model = "212",
                        Capacity = 500,
                        Manufacturer = "Boeing",
                        MaxSpeed = 4000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
