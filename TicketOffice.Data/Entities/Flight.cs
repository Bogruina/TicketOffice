
namespace TicketOffice.Data.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime BoadrTill { get; set; }
        public int TicketId { get; set; }
        public Ticket Ticket { get; set; }
        public Plane Plane { get; set; }
    }
}
