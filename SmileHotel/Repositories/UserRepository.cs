using System.Collections.Generic;
using SmileHotel.Models;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace SmileHotel.Repositories
{
    public class UserRepository
    {
        private string connetionString = @"server=remotemysql.com;database=8wdwbHzKHP;UID=8wdwbHzKHP;password=kPRONAzKzw";
        private MySqlConnection cnn;
        private string query;
        private MySqlDataReader DataReader;
        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            // TODO: Get users from DB
            query = "SELECT * FROM Users;";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MySqlCommand SqlQuery = new MySqlCommand(query, cnn);
            DataReader = SqlQuery.ExecuteReader();
            while(DataReader.Read())
            {
                User ToAdd = new User();
                ToAdd.Id = DataReader.GetInt32(0);
                ToAdd.Name = DataReader.GetString(1);
                ToAdd.PhoneNumber = DataReader.GetString(2);
                users.Add(ToAdd);
            }
            cnn.Close();

            return users;
        }

        public User GetUser(int id)
        {
            var user = new User();

            // TODO: Get user from DB
            query = "SELECT * FROM Users WHERE ID = " + id.ToString() + ";";
            cnn = new MySqlConnection(connetionString);
            cnn.Open();
            MySqlCommand SqlQuery = new MySqlCommand(query, cnn);
            DataReader = SqlQuery.ExecuteReader();
            DataReader.Read();
            user.Id = DataReader.GetInt32(0);
            user.Name = DataReader.GetString(1);
            user.PhoneNumber = DataReader.GetString(2);
            cnn.Close();
            return user;
        }

        public User AddOrUpdateUser(User user)
        {
            if (user.Id <= 0)
            {
                List<User> users = GetAllUsers();
                int maxID = 0;
                foreach(User user1 in users)
                {
                    if(maxID < user1.Id)
                    {
                        maxID = user1.Id;
                    }
                }
                maxID++;
                query = "INSERT INTO Users (`ID`, `Name`, `PhoneNumber`) VALUES ('"+ maxID.ToString() +"','" + user.Name + "', '" + user.PhoneNumber + "');";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                MySqlCommand SqlQuery = new MySqlCommand(query, cnn);
                SqlQuery.ExecuteNonQuery();
                cnn.Close();
            }
            else
            {
                // TODO: Update user
                query = "UPDATE Users " +
                    "SET Name = '" + user.Name + "' , PhoneNumber = '" + user.PhoneNumber + "'" +
                    " WHERE ID = " + user.Id.ToString() + ";";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                MySqlCommand SqlQuery = new MySqlCommand(query, cnn);
                SqlQuery.ExecuteNonQuery();
                cnn.Close();
            }

            // TODO: Map back to param user and return it

            return user;
        }

        public bool DeleteUser(int id)
        {
            // TODO: Delete user
            // TODO: Use try catch to see if SQL was made successfully
            try
            {
                query = "DELETE FROM Users WHERE ID = " + id.ToString() + ";";
                cnn = new MySqlConnection(connetionString);
                cnn.Open();
                MySqlCommand SqlQuery = new MySqlCommand(query, cnn);
                SqlQuery.ExecuteNonQuery();
                cnn.Close();
            }
            catch (SqlException e)
            {
                return false;
            }
            return true;
        }
    }
}
