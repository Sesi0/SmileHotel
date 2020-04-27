using System.Collections.Generic;
using SmileHotel.Models;
using SmileHotel.Helpers;
using MySql.Data.MySqlClient;
using System;

namespace SmileHotel.Repositories
{
    public class ClientRepository
    {
        private string query;

        public List<Client> GetAllClients()
        {
            var clients = new List<Client>();
            this.query = "SELECT * FROM Clients;";

            using (var connection = RepositoryHelper.OpenMySQLConnetion())
            using (var command = new MySqlCommand(this.query, connection))
            using (var dataReader = command.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    Client toAdd = new Client();
                    toAdd.Id = dataReader.GetInt32(0);
                    toAdd.Name = dataReader.GetString(1);
                    toAdd.PersonalDocNumber = dataReader.GetString(2);
                    toAdd.PhoneNumber = dataReader.GetString(3);
                    clients.Add(toAdd);
                }
            }

            return clients;
        }

        public Client GetClient(int id)
        {
            var client = new Client();
            this.query = "SELECT * FROM Clients WHERE ID = " + id.ToString() + ";";

            using (var connection = RepositoryHelper.OpenMySQLConnetion())
            using (var command = new MySqlCommand(this.query, connection))
            using (var dataReader = command.ExecuteReader())
            {
                dataReader.Read();
                client.Id = dataReader.GetInt32(0);
                client.Name = dataReader.GetString(1);
                client.PersonalDocNumber = dataReader.GetString(2);
                client.PhoneNumber = dataReader.GetString(3);
            }
            
            return client;
        }

        public Client AddOrUpdateClient(Client client)
        {
            if (client.Id <= 0)
            {
                List<Client> clients = this.GetAllClients();
                int maxID = 1;
                foreach (Client client1 in clients)
                {
                    if (maxID < client1.Id)
                    {
                        maxID = client1.Id;
                    }

                    maxID++;
                }

                this.query = "INSERT INTO Clients (`ID`, `Name`, `PersonalDocNumber`, `PhoneNumber`) VALUES ('" + maxID.ToString() + "','" + client.Name + "', '" + client.PersonalDocNumber + "' , '" + client.PhoneNumber + "');";
                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                this.query = "UPDATE Clients " +
                    "SET Name = '" + client.Name + "' , PersonalDocNumber = '" + client.PersonalDocNumber + "' , PhoneNumber = '" + client.PhoneNumber + "'" +
                    " WHERE ID = " + client.Id.ToString() + ";";
                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            return client;
        }

        public bool DeleteClient(int id)
        {
            try
            {
                this.query = "DELETE FROM Clients WHERE ID = " + id.ToString() + ";";
                using (var connection = RepositoryHelper.OpenMySQLConnetion())
                using (var command = new MySqlCommand(this.query, connection))
                {
                    command.ExecuteNonQuery();
                }

                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
