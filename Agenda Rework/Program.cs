using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Agenda_Rework
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
<<<<<<< HEAD
            Application.Run(new MainForm());
=======
            Application.Run(new LoginForm());
            Application.Exit();
>>>>>>> f9d8cd3e06baa2a54f0c82d5b3373435776747ee
        }
    }
}
