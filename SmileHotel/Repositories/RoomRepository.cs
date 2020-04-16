using System.Collections.Generic;
using SmileHotel.Models;

namespace SmileHotel.Repositories
{
    public class RoomRepository
    {
        public List<Room> GetAllRooms()
        {
            var rooms = new List<Room>();

            // TODO: Get rooms from DB

            return rooms;
        }

        public Room GetRoom(int id)
        {
            var room = new Room();

            // TODO: Get room from DB

            return room;
        }

        public Room AddOrUpdateRoom(Room room)
        {
            if (room.Id <= 0)
            {
                // TODO: Add room
            }
            else
            {
                // TODO: Update room
            }

            // TODO: Map back to param room and return it

            return room;
        }

        public bool DeleteRoom(int id)
        {
            // TODO: Delete room
            // TODO: Use try catch to see if SQL was made successfully

            return true;
        }
    }
}
