
namespace TicketOffice.Data.Entities
{
    public class Flight
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime BoadrTill { get; set; }
        public int PlaneId { get; set; }
        public Plane Plane { get; set; }
    }
}
