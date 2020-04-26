using System.Collections.Generic;
using SmileHotel.Models;
using SmileHotel.Helpers;
using MySql.Data.MySqlClient;
namespace SmileHotel.Repositories

namespace SmileHotel.Repositories
{ 
    public class ReservationRepository
    {
        private string query;
        private MySqlDataReader DataReader;
        public List<Reservation> GetAllReservations()
        {
            var reservations = new List<Reservation>();

            // TODO: Get reservations from DB
            query = "SELECT * FROM Reservations;";
            MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
            DataReader = SqlQuery.ExecuteReader();
            Reservation toAdd = new Reservation();
            while (DataReader.Read())
            {
                toAdd.Id = DataReader.GetInt32(0);
                toAdd.StartDate = DataReader.GetDateTime(4);
                toAdd.Duration = DataReader.GetInt32(5);
            }
            DataReader.Close();
            List<Reservation> toReturn = new List<Reservation>();
            foreach (Reservation res in reservations)
            {
                toReturn.Add(AssignReservation(res));
            }
            return toReturn;
        }

        public Reservation GetReservation(int id)
        {
            // TODO: Get reservation from DB

            var reservation = new Reservation();
            query = "SELECT * FROM Reservations;";
            MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
            DataReader = SqlQuery.ExecuteReader();
            DataReader.Read();
            reservation.Id = DataReader.GetInt32(0);
            reservation.StartDate = DataReader.GetDateTime(4);
            reservation.Duration = DataReader.GetInt32(5);
            DataReader.Close();
            reservation = AssignReservation(reservation);

            return reservation;
        }

        public Reservation AssignReservation(Reservation reservation)
        {
            query = "SELECT Rooms_idRooms, Clients_idClients, Users_idUsers FROM Reservations WHERE ID = " + reservation.Id + ";";
            MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
            DataReader = SqlQuery.ExecuteReader();
            DataReader.Read();
            int RoomID = DataReader.GetInt32(0);
            int ClientID = DataReader.GetInt32(1);
            int UserID = DataReader.GetInt32(2);
            DataReader.Close();
            RoomRepository roomRepository = new RoomRepository();
            reservation.Room = roomRepository.GetRoom(RoomID);
            ClientRepository clientRepository = new ClientRepository();
            reservation.Client = clientRepository.GetClient(ClientID);
            UserRepository userRepository = new UserRepository();
            reservation.User = userRepository.GetUser(UserID);
            return reservation;
        }

        public Reservation AddOrUpdateReservation(Reservation reservation)
        {
            if (reservation.Id <= 0)
            {
                // TODO: Add reservation
                query = "SELECT ID FROM Reservations;";
                MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
                DataReader = SqlQuery.ExecuteReader();
                List<int> IDs = new List<int>();
                while (DataReader.Read())
                {
                    IDs.Add(DataReader.GetInt32(0));
                }
                DataReader.Close();
                int newID = 0;
                foreach (int ID in IDs)
                {
                    if (newID < ID)
                    {
                        newID = ID;
                    }
                }
                newID++;
                query = "INSERT INTO Reservations (`ID`, `Rooms_idRooms`, `Clietns_idClients`, `Users_idUsers`, `StartDate`, `Duration`) VALUES ('" + newID.ToString() + "','" + reservation.Room.Id.ToString() + "', '" + reservation.Client.Id.ToString() + "' , '" + reservation.User.Id.ToString() + "', '" + reservation.StartDate.ToString() + "', '" + reservation.Duration.ToString() + "');";
                SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
                SqlQuery.ExecuteNonQuery();
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
            try
            {
                query = "DELETE FROM Reservations WHERE ID = " + id.ToString() + ";";
                MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
                SqlQuery.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException e)
            {
                return false;
            }
        }
    }
}
