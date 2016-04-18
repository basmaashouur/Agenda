using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Agenda_Rework
{
    public class user
    {

        string username, pass, gender;


        string _username
        {
            get { return this.username; }
            set { this.username = value; }
        }

        string _pass
        {

            get { return this.pass; }
            set { this.pass = value; }
        }

        string _gender
        {

            get { return this.gender; }
            set { this.gender = value; }
        }



        public bool create(string newuser, string newpass, string newgender)
        {
            try
            {
                FileStream fs = new FileStream("Users.dat", FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(newuser + "|" + newpass + "|" + newgender);
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
