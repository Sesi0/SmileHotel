using System.Collections.Generic;
using SmileHotel.Models;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Globalization;
using SmileHotel.Helpers;
using System;

namespace SmileHotel.Repositories
{
    public class RoomRepository
    {
        private string query;

        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();

            this.query = "SELECT * FROM Rooms;";
            using (var connection = RepositoryHelper.OpenMySQLConnetion())
            using (var command = new MySqlCommand(this.query, connection))
            using (var dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Room ToAdd = new Room();
                    ToAdd.Id = dataReader.GetInt32(0);
                    ToAdd.Number = dataReader.GetInt32(1);
                    ToAdd.Capacity = dataReader.GetInt32(2);
                    ToAdd.PricePerNight = dataReader.GetFloat(3);
                    rooms.Add(ToAdd);
                }
            }

            return rooms;
        }

        public Room GetRoom(int id)
        {
            var room = new Room();
            this.query = "SELECT * FROM Rooms WHERE ID = " + id.ToString() + ";";

            using (var connection = RepositoryHelper.OpenMySQLConnetion())
            using (var command = new MySqlCommand(this.query, connection))
            using (var dataReader = command.ExecuteReader())
            {
                dataReader.Read();
                room.Id = dataReader.GetInt32(0);
                room.Number = dataReader.GetInt32(1);
                room.Capacity = dataReader.GetInt32(2);
                room.PricePerNight = dataReader.GetFloat(3);
            }

            return room;
        }

        public Room AddOrUpdateRoom(Room room)
        {
            if (room.Id <= 0)
            {
                List<Room> rooms = this.GetAllRooms();
                int maxID = 1;
                foreach (Room room1 in rooms)
                {
                    if (maxID < room1.Id)
                    {
                        maxID = room1.Id;
                    }

                    maxID++;
                }


                this.query = "INSERT INTO Rooms (`ID`, `RoomNumber`, `RoomCapacity`, `PricePerNight`) VALUES ('" + maxID.ToString() + "','" + room.Number + "', '" + room.Capacity.ToString() + "' , '" + room.PricePerNight.ToString("F", CultureInfo.CreateSpecificCulture("en-US")) + "');";
                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                this.query = "UPDATE Rooms " +
                    "SET RoomNumber = '" + room.Number + "' , RoomCapacity = '" + room.Capacity.ToString() + "' , PricePerNight = '" + room.PricePerNight.ToString() + "'" +
                    " WHERE ID = " + room.Id.ToString() + ";";
                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            return room;
        }

        public bool DeleteRoom(int id)
        {
            try
            {
                this.query = "DELETE FROM Rooms WHERE ID = " + id.ToString() + ";";
                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }
    }
}
