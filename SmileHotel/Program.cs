﻿using System;
using System.Windows.Forms;
using SmileHotel.Forms;
using SmileHotel.Models;
using System.Collections.Generic;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
