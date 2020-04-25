using System.Collections.Generic;
using SmileHotel.Models;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Globalization;
using SmileHotel.Helpers;

namespace SmileHotel.Repositories
{
    public class RoomRepository
    {
        private string query;
        private MySqlDataReader DataReader;
        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();

            // TODO: Get rooms from DB
            query = "SELECT * FROM Rooms;";
            MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
            DataReader = SqlQuery.ExecuteReader();
            while (DataReader.Read())
            {
                Room ToAdd = new Room();
                ToAdd.Id = DataReader.GetInt32(0);
                ToAdd.Number = DataReader.GetInt32(1).ToString();
                ToAdd.Capacity = DataReader.GetInt32(2);
                ToAdd.PricePerNight = DataReader.GetFloat(3);
                rooms.Add(ToAdd);
            }
            DataReader.Close();

            return rooms;
        }

        public Room GetRoom(int id)
        {
            var room = new Room();

            // TODO: Get room from DB

            query = "SELECT * FROM Rooms WHERE ID = " + id.ToString() + ";";
            MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
            DataReader = SqlQuery.ExecuteReader();
            DataReader.ReadAsync();
            room.Id = DataReader.GetInt32(0);
            room.Number = DataReader.GetString(1);
            room.Capacity = DataReader.GetInt32(2);
            room.PricePerNight = DataReader.GetFloat(3);
            DataReader.Close();
            return room;
        }

        public Room AddOrUpdateRoom(Room room)
        {
            if (room.Id <= 0)
            {
                // TODO: Add room
                List<Room> rooms = GetAllRooms();
                int maxID = 0;
                foreach (Room room1 in rooms)
                {
                    if (maxID < room1.Id)
                    {
                        maxID = room1.Id;
                    }
                }
                maxID++;
                query = "INSERT INTO Rooms (`ID`, `RoomNumber`, `RoomCapacity`, `PricePerNight`) VALUES ('" + maxID.ToString() + "','" + room.Number + "', '" + room.Capacity.ToString() + "' , '" + room.PricePerNight.ToString("F", CultureInfo.CreateSpecificCulture("en-US")) + "');";
                MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
                SqlQuery.ExecuteNonQuery();
            }
            else
            {
                // TODO: Update room
                query = "UPDATE Rooms " +
                    "SET RoomNumber = '" + room.Number + "' , RoomCapacity = '" + room.Capacity.ToString() + "' , PricePerNight = '" + room.PricePerNight.ToString() + "'" +
                    " WHERE ID = " + room.Id.ToString() + ";";
                MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
                SqlQuery.ExecuteNonQuery();
            }

            return room;
        }

        public bool DeleteRoom(int id)
        {
            // TODO: Delete room
            // TODO: Use try catch to see if SQL was made successfully
            try
            {
                query = "DELETE FROM Rooms WHERE ID = " + id.ToString() + ";";
                MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
                SqlQuery.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                return false;
            }
            return true;
        }
    }
}
