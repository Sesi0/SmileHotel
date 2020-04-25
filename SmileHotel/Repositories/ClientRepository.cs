using System.Collections.Generic;
using SmileHotel.Models;
using SmileHotel.Helpers;
using MySql.Data.MySqlClient;
namespace SmileHotel.Repositories
{
    public class ClientRepository
    {
        private string query;
        private MySqlDataReader DataReader;
        public List<Client> GetAllClients()
        {
            var clients = new List<Client>();

            // TODO: Get clients from DB
            query = "SELECT * FROM Clients;";
            MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
            DataReader = SqlQuery.ExecuteReader();
            while (DataReader.Read())
            {
                Client ToAdd = new Client();
                ToAdd.Id = DataReader.GetInt32(0);
                ToAdd.Name = DataReader.GetString(1);
                ToAdd.PersonalDocNumber = DataReader.GetString(2);
                ToAdd.PhoneNumber = DataReader.GetString(3);
                clients.Add(ToAdd);
            }
            DataReader.Close();

            return clients;
        }

        public Client GetClient(int id)
        {
            var Client = new Client();

            // TODO: Get Client from DB
            query = "SELECT * FROM Clients WHERE ID = " + id.ToString() + ";";
            MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
            DataReader = SqlQuery.ExecuteReader();
            DataReader.Read();
            Client.Id = DataReader.GetInt32(0);
            Client.Name = DataReader.GetString(1);
            Client.PersonalDocNumber = DataReader.GetString(2);
            Client.PhoneNumber = DataReader.GetString(3);
            DataReader.Close();
            return Client;
        }

        public Client AddOrUpdateClient(Client Client)
        {
            if (Client.Id <= 0)
            {
                // TODO: Add Client
                List<Client> clients = GetAllClients();
                int maxID = 0;
                foreach (Client client1 in clients)
                {
                    if (maxID < client1.Id)
                    {
                        maxID = client1.Id;
                    }
                }
                maxID++;
                query = "INSERT INTO Clients (`ID`, `Name`, `PersonalDocNumber`, `PhoneNumber`) VALUES ('" + maxID.ToString() + "','" + Client.Name + "', '" + Client.PersonalDocNumber + "' , '" + Client.PhoneNumber + "');";
                MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
                SqlQuery.ExecuteNonQuery();
            }
            else
            {
                // TODO: Update Client
                query = "UPDATE Clients " +
                    "SET Name = '" + Client.Name + "' , PersonalDocNumber = '" + Client.PersonalDocNumber + "' , PhoneNumber = '" + Client.PhoneNumber + "'" +
                    " WHERE ID = " + Client.Id.ToString() + ";";
                MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
                SqlQuery.ExecuteNonQuery();
            }

            // TODO: Map back to param Client and return it

            return Client;
        }

        public bool DeleteClient(int id)
        {
            // TODO: Delete Client
            // TODO: Use try catch to see if SQL was made successfully
            try
            {
                query = "DELETE FROM Clients WHERE ID = " + id.ToString() + ";";
                MySqlCommand SqlQuery = new MySqlCommand(query, SessionHelper.cnn);
                SqlQuery.ExecuteNonQuery();
                return true;
            }
            catch(MySqlException e)
            {
                return false;
            }
        }
    }
}
