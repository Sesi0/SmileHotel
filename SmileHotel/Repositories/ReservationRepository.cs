using System.Collections.Generic;
using SmileHotel.Models;
using SmileHotel.Helpers;
using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Linq;

namespace SmileHotel.Repositories
{
    public class ReservationRepository
    {
        private string query;

        public List<Reservation> GetAllReservations()
        {
            var reservations = new List<Reservation>();
            this.query = "SELECT * FROM Reservations;";

            using (var connection = RepositoryHelper.OpenMySQLConnetion())
            using (var command = new MySqlCommand(this.query, connection))
            using (var dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Reservation toAdd = new Reservation();
                    toAdd.Id = dataReader.GetInt32(0);
                    toAdd.StartDate = dataReader.GetDateTime(4);
                    toAdd.Duration = dataReader.GetInt32(5);
                    reservations.Add(toAdd);
                }
            }

            return reservations.Select(r => this.AssignReservation(r)).ToList();
        }

        public List<Reservation> GetAllReservationsForRoom(int IDRoom)
        {
            var reservations = new List<Reservation>();
            this.query = "SELECT * FROM Reservations WHERE Rooms_idRooms = '" + IDRoom.ToString() + ";";

            using (var connection = RepositoryHelper.OpenMySQLConnetion())
            using (var command = new MySqlCommand(this.query, connection))
            using (var dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Reservation toAdd = new Reservation();
                    toAdd.Id = dataReader.GetInt32(0);
                    toAdd.StartDate = dataReader.GetDateTime(4);
                    toAdd.Duration = dataReader.GetInt32(5);
                    reservations.Add(toAdd);
                }
            }

            return reservations.Select(r => this.AssignReservation(r)).ToList();
        }

        public Reservation GetReservation(int id)
        {
            var reservation = new Reservation();
            this.query = "SELECT * FROM Reservations;";

            using (var connection = RepositoryHelper.OpenMySQLConnetion())
            using (var command = new MySqlCommand(this.query, connection))
            using (var dataReader = command.ExecuteReader())
            {
                dataReader.Read();
                reservation.Id = dataReader.GetInt32(0);
                reservation.StartDate = dataReader.GetDateTime(4);
                reservation.Duration = dataReader.GetInt32(5);
            }
            
            return this.AssignReservation(reservation);
        }

        public Reservation AssignReservation(Reservation reservation)
        {
            try
            {
                this.query = "SELECT Rooms_idRooms, Clients_idClients, Users_idUsers FROM Reservations WHERE ID = " + reservation.Id + ";";

                int roomID = 0;
                int clientID = 0;
                int userID = 0;

                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                using (var dataReader = command.ExecuteReader())
                {
                    dataReader.Read();
                    roomID = dataReader.GetInt32(0);
                    clientID = dataReader.GetInt32(1);
                    userID = dataReader.GetInt32(2);
                }

                RoomRepository roomRepository = new RoomRepository();
                reservation.Room = roomRepository.GetRoom(roomID);
                ClientRepository clientRepository = new ClientRepository();
                reservation.Client = clientRepository.GetClient(clientID);
                UserRepository userRepository = new UserRepository();
                reservation.User = userRepository.GetUser(userID);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return reservation;
        }

        public Reservation AddOrUpdateReservation(Reservation reservation)
        {
            if (reservation.Id <= 0)
            {
                List<int> IDs = new List<int>();
                this.query = "SELECT ID FROM Reservations;";

                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                using (var dataReader = command.ExecuteReader())
                {
                    
                    while (dataReader.Read())
                    {
                        IDs.Add(dataReader.GetInt32(0));
                    }
                }

                int newID = 0;
                foreach (int ID in IDs)
                {
                    if (newID < ID)
                    {
                        newID = ID;
                    }
                }

                newID++;

                this.query = "INSERT INTO Reservations (`ID`, `Rooms_idRooms`, `Clients_idClients`, `Users_idUsers`, `StartDate`, `Duration`) VALUES ('" + newID.ToString() + "','" + reservation.Room.Id.ToString() + "', '" + reservation.Client.Id.ToString() + "' , '" + reservation.User.Id.ToString() + "', '" + reservation.StartDate.ToString("yyyy-MM-dd") + "', '" + reservation.Duration.ToString() + "');";
                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                this.query = "UPDATE Reservations " +
                                    "SET Rooms_idRooms = " + reservation.Room.Id+ " , Clients_idClients = " + reservation.Client.Id + " , StartDate = '" + reservation.StartDate.ToString("yyyy-MM-dd") + "', Duration = '" + reservation.Duration.ToString() + "'" +
                                    " WHERE ID = " + reservation.Id.ToString() + ";";
                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            return reservation;
        }

        public bool DeleteReservation(int id)
        {
            try
            {
                this.query = "DELETE FROM Reservations WHERE ID = " + id.ToString() + ";";
                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                {
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<Reservation> GetActiveReservations()
        {
            List<Reservation> ToReturn = new List<Reservation>();
            DateTime Current = DateTime.Now;
            DateTime ToCompare = new DateTime();
            List<Reservation> reservations = GetAllReservations();
            foreach(Reservation reservation in reservations)
            {
                ToCompare = reservation.StartDate;
                if(Current.Date == ToCompare.Date)
                {
                    ToReturn.Add(reservation);
                }
                else if (DateTime.Compare(Current, ToCompare) > 0)
                {
                    ToCompare.AddDays(reservation.Duration);
                    if (DateTime.Compare(Current, ToCompare) < 0)
                    {
                        ToReturn.Add(reservation);
                    }
                }
            }
            return ToReturn;
        }
        public int GetProductivityForAroom(int RoomID, DateTime MonthStart)
        {
            int Productivity = 0;
            var reservations = GetAllReservationsForRoom(RoomID);
            DateTime toCompare = new DateTime();
            DateTime CurrentMonth = MonthStart;
            foreach (Reservation res in reservations)
            {
                CurrentMonth = MonthStart;
                toCompare = res.StartDate;
                if (DateTime.Compare(CurrentMonth, toCompare) <= 0)
                {
                    //reservation starts afer moth start
                    CurrentMonth = CurrentMonth.AddMonths(1);
                    if (DateTime.Compare(CurrentMonth, toCompare) > 0)
                    {
                        //reservation starts requested month
                        toCompare.AddDays(res.Duration);
                        if (DateTime.Compare(CurrentMonth, toCompare) >= 0)
                        {
                            //reservation stays in current month
                            Productivity = Productivity + res.Duration;
                        }
                        else
                        {
                            //reservation extemds past current month
                            Productivity = Productivity + (res.Duration - toCompare.Day);
                        }
                    }
                }
                else
                {
                    //reservation starts before requested month
                    toCompare.AddDays(res.Duration);
                    if (DateTime.Compare(CurrentMonth, toCompare) > 0)
                    {
                        //Reservation starts previous month but extends into requested one
                        Productivity = Productivity + toCompare.Day;
                    }
                }

            }
            return Productivity;
        }
        public int GetProductivityForHotel(DateTime MonthStart)
        {
            int Productivity = 0;
            var reservations = GetAllReservations();
            DateTime toCompare = new DateTime();
            foreach (Reservation res in reservations)
            {
                DateTime CurrentMonth = MonthStart;
                toCompare = res.StartDate;
                if (DateTime.Compare(CurrentMonth, toCompare) <= 0)
                {
                    //reservation starts afer moth start
                    CurrentMonth = CurrentMonth.AddMonths(1);
                    if (DateTime.Compare(CurrentMonth, toCompare) > 0)
                    {
                        //reservation starts requested month
                        toCompare.AddDays(res.Duration);
                        if (DateTime.Compare(CurrentMonth, toCompare) >= 0)
                        {
                            //reservation stays in current month
                            Productivity = Productivity + res.Duration;
                        }
                        else
                        {
                            //reservation extemds past current month
                            Productivity = Productivity + (res.Duration - toCompare.Day);
                        }
                    }
                }
                else
                {
                    //reservation starts before requested month
                    toCompare.AddDays(res.Duration);
                    if (DateTime.Compare(CurrentMonth, toCompare) > 0)
                    {
                        //Reservation starts previous month but extends into requested one
                        Productivity = Productivity + toCompare.Day;
                    }
                }

            }
            return Productivity;
        }
    }
}
