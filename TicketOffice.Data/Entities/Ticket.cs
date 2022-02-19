
using System.ComponentModel.DataAnnotations;

namespace TicketOffice.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public int Seat { get; set; }
        public int GateNumber { get; set; }
        public int PassengerId { get; set; }
        public Passenger Passanger { get; set; }
        public Flight Flight { get; set; }
    }
}
