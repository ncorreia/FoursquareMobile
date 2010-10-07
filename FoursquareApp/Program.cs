using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Configuration;

namespace FoursquareApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            ConfigurationSettings.LoadConfig();
            Application.Run(new MainForm());
        }
    }
}