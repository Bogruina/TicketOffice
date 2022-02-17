using TicketOffice.Data;
using Microsoft.EntityFrameworkCore;

namespace TicketOffice.Api.AppStart
{
    public static class DatabaseContextExtensions
    {
        public static void AddCustomSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
            //services.BuildServiceProvider().GetService<ApplicationDbContext>().Database.Migrate();
        }
    }
}
