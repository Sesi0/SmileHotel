using System.Collections.Generic;
using SmileHotel.Models;

namespace SmileHotel.sRepositories
{
    public class UserRepository
    {
        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            // TODO: Get users from DB

            return users;
        }

        public User GetUser(int id)
        {
            var user = new User();

            // TODO: Get user from DB

            return user;
        }

        public User AddOrUpdateUser(User user)
        {
            if (user.Id <= 0)
            {
                // TODO: Add user
            }
            else
            {
                // TODO: Update user
            }

            // TODO: Map back to param user and return it

            return user;
        }

        public bool DeleteUser(int id)
        {
            // TODO: Delete user
            // TODO: Use try catch to see if SQL was made successfully

            return true;
        }
    }
}
