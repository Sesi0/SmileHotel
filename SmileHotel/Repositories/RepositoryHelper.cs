using MySql.Data.MySqlClient;

namespace SmileHotel.Repositories
{
    public static class RepositoryHelper
    {
        private static string connetionString = @"server=db4free.net;database=smilehotel;UID=smilehoteluser;password=3_MyZxzwFFu5_kg";

        public static MySqlConnection OpenMySQLConnetion()
        {
            var connection = new MySqlConnection(connetionString);
            connection.Open();
            return connection;
        }
    }
}
