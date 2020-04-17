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
            query = "SELECT * FROM Users WHERE ID = " + id.ToString();
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            SqlCommand SqlQuery = new SqlCommand(query, cnn);
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
                query = "INSERT Users (ID,Name,PhoneNumber)" +
                    "VALUES (SELECT ID FROM Users WHERE id = max(ID) + 1, " + user.Name + ", " + user.PhoneNumber + ")";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand SqlQuery = new SqlCommand(query, cnn);
                SqlQuery.ExecuteNonQuery();
                cnn.Close();
            }
            else
            {
                // TODO: Update user
                query = "UPDARE Users" +
                    "SET Name =" + user.Name + ",PhoneNumber =" + user.PhoneNumber + "WHERE ID =" + user.Id + ";";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand SqlQuery = new SqlCommand(query, cnn);
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
                query = "SELECT * FROM Users WHERE ID = ";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                SqlCommand SqlQuery = new SqlCommand(query, cnn);
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
