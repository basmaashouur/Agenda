using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Agenda_Rework
{



    public partial class Signup : MetroFramework.Forms.MetroForm
    {
        bool female, male = false;

        public Signup()
        {
            InitializeComponent();

        }

        private void Signup_Load(object sender, EventArgs e)
        {


        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            Namefield.Clear();
        }


        private void Malebutton_Click(object sender, EventArgs e)
        {
            this.male = true;
            this.female = false;
        }

        private void Femalebutton_Click(object sender, EventArgs e)
        {
            this.male = false;
            this.female = true;
        }

        private void adduserbutton_Click(object sender, EventArgs e)
        {
            bool err_flag = false;

            //Check if name already exists.
            if (!File.Exists("Users.dat"))
            {
                File.Create("Users.dat");
            }
            if (new FileInfo("Users.dat").Length != 0)
            {
                using (FileStream fs = new FileStream("Users.dat", FileMode.Open, FileAccess.ReadWrite))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string record = sr.ReadLine();
                        while (record != null)
                        {
                            if (!record.Contains(Namefield.Text.ToLower()))
                            {
                                record = sr.ReadLine();
                                continue;
                            }
                            else
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Sorry, name already exists.", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                err_flag = true;
                                break;
                            }
                        }
                    }

                }
            }//END OF NAME CHECK

            //PASSWORD MATCH CHECK
            if (pass1.Text != pass2.Text)
            {
                MetroFramework.MetroMessageBox.Show(this, "Passwords don't match.", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                err_flag = true;
            }
            //END PASSWORD MATCH CHECK

            if (!err_flag)
            {
                using (FileStream fs = new FileStream("Users.dat", FileMode.Append, FileAccess.Write))
                {
                    string record = "";
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        
                            record = Namefield.Text.ToLower() + '|' + pass2.Text + '|';
                            if (female) { record += "female;"; } else { record += "male;"; }
                      
                        sw.Write(record);
                        MetroFramework.MetroMessageBox.Show(this, "User Created!\nYou may now login using your new credentials", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginForm LF = new LoginForm();
                        LF.Show();
                        this.Hide();
                        
                    }
                }
            }
        }

        private void pass1_Enter(object sender, EventArgs e)
        {
            pass1.Clear();
            pass1.UseSystemPasswordChar = true;
        }

        private void pass2_Enter(object sender, EventArgs e)
        {
            pass2.Clear();
            pass2.UseSystemPasswordChar = true;
        }
    }
}