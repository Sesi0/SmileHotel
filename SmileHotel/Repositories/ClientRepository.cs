using System.Collections.Generic;
using SmileHotel.Models;

namespace SmileHotel.Repositories
{
    public class ClientRepository
    {
        public List<Client> GetAllClients()
        {
            var clients = new List<Client>();

            // TODO: Get clients from DB

            return clients;
        }

        public Client GetClient(int id)
        {
            var Client = new Client();

            // TODO: Get Client from DB

            return Client;
        }

        public Client AddOrUpdateClient(Client Client)
        {
            if (Client.Id <= 0)
            {
                // TODO: Add Client
            }
            else
            {
                // TODO: Update Client
            }

            // TODO: Map back to param Client and return it

            return Client;
        }

        public bool DeleteClient(int id)
        {
            // TODO: Delete Client
            // TODO: Use try catch to see if SQL was made successfully

            return true;
        }
    }
}
