using System;
using System.Windows.Forms;
using SmileHotel.Forms;
using SmileHotel.Models;
using SmileHotel.Repositories;

namespace SmileHotel
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            User newUSer = new User();
            UserRepository userRepository = new UserRepository();
            newUSer.Id = -1;
            newUSer.Name = "Test";
            newUSer.PhoneNumber = "Test";
            userRepository.AddOrUpdateUser(newUSer);
            User NewUser2 = new User();
            NewUser2 = userRepository.GetUser(1);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
