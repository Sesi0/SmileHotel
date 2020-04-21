using System;
using System.Windows.Forms;
using SmileHotel.Forms;
using SmileHotel.Models;
using SmileHotel.Repositories;
using System.Collections.Generic;

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
            if(userRepository.DeleteUser(8))
            {
                MessageBox.Show("Success");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
