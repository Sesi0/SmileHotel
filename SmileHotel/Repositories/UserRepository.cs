using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using SmileHotel.Models;

namespace SmileHotel.Repositories
{
    public class UserRepository
    {
        private string query;

        public List<User> GetAllUsers()
        {
            var users = new List<User>();
            this.query = "SELECT * FROM Users;";

            using (var connection = RepositoryHelper.OpenMySQLConnetion())
            using (var command = new MySqlCommand(this.query, connection))
            using (var dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    User userToAdd = new User();
                    userToAdd.Id = dataReader.GetInt32(0);
                    userToAdd.Name = dataReader.GetString(1);
                    userToAdd.PhoneNumber = dataReader.GetString(2);
                    userToAdd.Password = dataReader.GetString(3);
                    users.Add(userToAdd);
                }
            }

            return users;
        }

        public User GetUser(int id)
        {
            var user = new User();
            this.query = "SELECT * FROM Users WHERE ID = " + id + ";";

            using (var connection = RepositoryHelper.OpenMySQLConnetion())
            using (var command = new MySqlCommand(this.query, connection))
            using (var dataReader = command.ExecuteReader())
            {
                dataReader.Read();
                user.Id = dataReader.GetInt32(0);
                user.Name = dataReader.GetString(1);
                user.PhoneNumber = dataReader.GetString(2);
                user.Password = dataReader.GetString(3);
            }
            
            return user;
        }

        public User GetUserWithPassword(string Name, string Password)
        {
            try
            {
                var user = new User();
                this.query = "SELECT * FROM Users WHERE Name = '" + Name + "' AND Password = '" + Password + "';";

                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                using (var dataReader = command.ExecuteReader())
                {
                    dataReader.Read();
                    user.Id = dataReader.GetInt32(0);
                    user.Name = dataReader.GetString(1);
                    user.PhoneNumber = dataReader.GetString(2);
                    user.Password = dataReader.GetString(3);
                }

                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public User AddOrUpdateUser(User user)
        {
            if (user.Id <= 0)
            {
                List<User> users = this.GetAllUsers();

                int maxID = 1;
                foreach (User user1 in users)
                {
                    if (maxID < user1.Id)
                    {
                        maxID = user1.Id;
                    }

                    maxID++;
                }

                this.query = "INSERT INTO Users (`ID`, `Name`, `PhoneNumber`, `Password`) VALUES ('" + maxID.ToString() + "','" + user.Name + "', '" + user.PhoneNumber + "', '" + user.Password + "');";
                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                this.query = "UPDATE Users " +
                    "SET Name = '" + user.Name + "' , PhoneNumber = '" + user.PhoneNumber + "', Password = '" + user.Password + "'" +
                    " WHERE ID = " + user.Id + ";";
                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            return user;
        }

        public bool DeleteUser(int id)
        {
            try
            {
                this.query = "DELETE FROM Users WHERE ID = " + id.ToString() + ";";
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