using Microsoft.AspNetCore.Mvc;
using TicketOffice.Data;
using TicketOffice.Data.Entities;

namespace TicketOffice.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlaneController : Controller
    {
        private ApplicationDbContext _db;
        public PlaneController(ApplicationDbContext context)
        {
            _db = context;
        }
        
        [HttpGet(Name = "GetAllPlanes")]
        public IEnumerable<Plane> Get()
        {
            return _db.Planes.ToList();
        }
    }
}
