
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketOffice.Data.Entities
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ThirdName { get; set; }
        [NotMapped]
        public DateOnly Birthday { get; set; }
        public string Email { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
    }
}
