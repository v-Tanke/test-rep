using System.Collections.Generic;

namespace WebApplication1.Data.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int SessionId { get; set; }

        public virtual Session Session { get; set; }

        public List<Seat> Seats { get; set; }

    }
}
