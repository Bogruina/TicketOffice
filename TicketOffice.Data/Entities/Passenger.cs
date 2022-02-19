
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketOffice.Data.Entities
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ThirdName { get; set; }
        public string Email { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
