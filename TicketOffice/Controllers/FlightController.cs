using Microsoft.AspNetCore.Mvc;
using TicketOffice.Data;
using TicketOffice.Data.Entities;

namespace TicketOffice.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : Controller
    {
        private ApplicationDbContext _db;
        public FlightController(ApplicationDbContext context)
        {
            _db = context;
        }

        [HttpGet]
        public IEnumerable<Flight> Index()
        {
            return _db.Flights.ToList();
        }
    }
}
