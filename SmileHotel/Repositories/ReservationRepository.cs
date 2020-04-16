using System.Collections.Generic;
using SmileHotel.Models;

namespace SmileHotel.Repositories
{
    public class ReservationRepository
    {
        public List<Reservation> GetAllReservations()
        {
            var reservations = new List<Reservation>();

            // TODO: Get reservations from DB

            return reservations;
        }

        public Reservation GetReservation(int id)
        {
            var reservation = new Reservation();

            // TODO: Get reservation from DB

            return reservation;
        }

        public Reservation AddOrUpdateReservation(Reservation reservation)
        {
            if (reservation.Id <= 0)
            {
                // TODO: Add reservation
            }
            else
            {
                // TODO: Update reservation
            }

            // TODO: Map back to param reservation and return it

            return reservation;
        }

        public bool DeleteReservation(int id)
        {
            // TODO: Delete reservation
            // TODO: Use try catch to see if SQL was made successfully

            return true;
        }
    }
}
