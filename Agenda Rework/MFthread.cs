using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda_Rework
{
    class MFthread
    {
        public static bool load_flag = false;
        public void ShowMain() {
            MainForm MF = new MainForm();
            //Placement of the following block of code is subject to change.
            while (true) {
                if (MF != null) { MFthread.load_flag = true; break; }            
            }
            MF.Show();
            Application.Run();
            
        }








    }
}
