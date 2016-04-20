using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Agenda_Rework
{
    public class user
    {

      



        public bool create(string newuser, string newpass, string newgender)
        {
            try
            {
                FileStream fs = new FileStream("Users.dat", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(newuser.ToLower() + "|" + @newpass + "|" + newgender);
                sw.Flush();
                sw.Close();
                fs.Close();
                return(true);
                
            }
            catch (IOException) {

                return (false);
                
            }
        }





    }
}
