
namespace TicketOffice.Data.Entities
{
    public class Passenger
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ThirdName { get; set; }
        public DateOnly Birthday { get; set; }
        public string Email { get; set; }
    }
}
