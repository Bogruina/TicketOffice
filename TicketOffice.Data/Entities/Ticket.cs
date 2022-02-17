
namespace TicketOffice.Data.Entities
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Class { get; set; }
        public int Seat { get; set; }
        public int GateNumber { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
    }
}
