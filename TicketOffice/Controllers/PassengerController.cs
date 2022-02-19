using Microsoft.AspNetCore.Mvc;
using TicketOffice.Data;
using TicketOffice.Data.Entities;

namespace TicketOffice.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PassengerController : Controller
    {
        private ApplicationDbContext _db;
        public PassengerController(ApplicationDbContext context)
        {
            _db = context;
        }
        [HttpGet]
        public IEnumerable<Passenger> Index()
        {
            return _db.Passengers.ToList();
        }
    }
}
