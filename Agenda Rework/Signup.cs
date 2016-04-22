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

            //Check if name already exists.

            bool Err_flag= false;
            if (File.Exists("Users.dat"))
            {
            FileStream fs = new FileStream("Users.dat",FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

                string record = sr.ReadLine();
                while (record != null)
                {
                    if (record.Split('|')[0].ToLower() == Namefield.Text.ToLower())
                    {
                        Errorlabel.Text = "Sorry, Name already exists.";
                        Err_flag = true;
                        break;
                    }
                    record = sr.ReadLine();

                }
                sr.Close();
                fs.Close();
                
            }
            //End of name check.

            //Password matching check.
            if (pass1.Text != pass2.Text) {
                Err_flag = true;
                Errorlabel.Text += "\nError: Passwords Don't match, Perhaps type slower?";}
            //End password matching check


            //Gender specification
            string gender;
            if (this.female == true) { gender = "Female"; } else { gender = "Male"; }
            //End Gender specification

            //If no errors, create a new user object and call the "create" method to create a record and write it to users.dat
            if (Err_flag == false) {
                
                user newuser = new user();
                if (!newuser.create(Namefield.Text, pass1.Text, gender))
                {
                    IOException err = new IOException();
                    MetroFramework.MetroMessageBox.Show(this, "Error" + err.ToString(), "Error", MessageBoxButtons.OK);
                }
                else {
                    MetroFramework.MetroMessageBox.Show(this, "User Created.\nYou may now login with your new credentials.", "Success!", MessageBoxButtons.OK);
                    this.Hide();
                    LoginForm LF = new LoginForm();
                    LF.Show();
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