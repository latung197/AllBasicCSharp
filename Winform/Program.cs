﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        public static string _connnectString = "";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main()); 
        }

    }
}
