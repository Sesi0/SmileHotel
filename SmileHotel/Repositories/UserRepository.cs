using System.Collections.Generic;
using SmileHotel.Models;
using System.Data;
using System.Data.SqlClient;

namespace SmileHotel.sRepositories
{
    public class UserRepository
    {
        string connetionString = @"Data Source=remotemysql.com;Initial Catalog=8wdwbHzKHP;User ID=8wdwbHzKHP;Password=kPRONAzKzw";
        SqlConnection cnn;
        string query;
        SqlDataReader DataReader;
        public List<User> GetAllUsers()
        {
            var users = new List<User>();

            // TODO: Get users from DB
            query = "SELECT * FROM Users";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand SqlQuery = new SqlCommand(query, cnn);
            DataReader = SqlQuery.ExecuteReader();
            while(DataReader.Read())
            {
                User ToAdd = new User();
                users.Add(ToAdd);
            }
            cnn.Close();

            return users;
        }

        public User GetUser(int id)
        {
            var user = new User();

            // TODO: Get user from DB
            query = "SELECT * FROM Users WHERE ID = " + id.ToString();
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand SqlQuery = new SqlCommand(query, cnn);
            DataReader = SqlQuery.ExecuteReader();
            DataReader.Read();
            cnn.Close();
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
