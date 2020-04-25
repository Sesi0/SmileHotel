using SmileHotel.Models;
using MySql.Data.MySqlClient;

namespace SmileHotel.Helpers
{
    public static class SessionHelper
    {
        public static User User { get; set; }
        public static string connetionString = @"server=db4free.net;database=smilehotel;UID=smilehoteluser;password=3_MyZxzwFFu5_kg";
        public static MySqlConnection cnn = new MySqlConnection(connetionString);
        public static bool OpenConnection()
        {
            try
            {
                cnn.Open();
                return true;
            }
            catch(MySqlException e)
            {
                return false;
            }
        }
        public static bool CloseConnection()
        {
            try
            {
                cnn.Close();
                return true;
            }
            catch(MySqlException e)
            {
                return false;
            }
        }
    }
}
