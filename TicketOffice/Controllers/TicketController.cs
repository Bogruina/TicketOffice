using Microsoft.AspNetCore.Mvc;
using TicketOffice.Data;
using TicketOffice.Data.Entities;

namespace TicketOffice.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : Controller
    {
        private ApplicationDbContext _db;
        public TicketController(ApplicationDbContext context)
        {
            _db = context;
        }
        [HttpGet]
        public IEnumerable<Ticket> Index()
        {
            return _db.Tickets.ToList();
        }
    }
}
