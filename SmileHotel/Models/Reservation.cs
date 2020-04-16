using System;

namespace SmileHotel.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public Client Client { get; set; }

        public Room Room { get; set; }

        public User User { get; set; }

        public DateTime StartDate { get; set; }

        public int Duration { get; set; }
    }
}
