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
    


    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public static class userdata {
            public static string current_user, user_gender; 
                    }


        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            Unamefield.Clear();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup su = new Signup();
            su.Show();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            loadinglabel.Visible = true;
            metroProgressSpinner1.Visible = true;


            if (File.Exists("Users.dat"))
            {
                FileStream login_fs = new FileStream("Users.dat", FileMode.Open, FileAccess.Read);
                StreamReader login_sr = new StreamReader(login_fs);

                string record = login_sr.ReadLine();
                while (record != null)
                {
                    if (record.Split('|')[0].ToLower() == Unamefield.Text.ToLower())
                    {
                        if (record.Split('|')[1] == passfield.Text)
                        {
       
                            Agenda_Rework.LoginForm.userdata.current_user = record.Split('|')[0];
                            Agenda_Rework.LoginForm.userdata.user_gender = record.Split('|')[2];
                                                      
                            MainForm MF = new MainForm();
                            MF.Show();
                            while (true) {
                                if (MF != null) { this.Hide(); break; }
                            
                            }
                            break;
                            
                        }

                    }
                    MetroFramework.MetroMessageBox.Show(this, "Wrong username or password.", "Oops..", MessageBoxButtons.OK);
                    loadinglabel.Visible = false;
                    metroProgressSpinner1.Visible = false;
                    record = login_sr.ReadLine();
                }

                login_fs.Close();
                login_sr.Close();

            }
            else {
             MetroFramework.MetroMessageBox.Show(this,"Database is empty, Please create at least 1 account first.","First time?",MessageBoxButtons.OK);
             loadinglabel.Visible = false;
             metroProgressSpinner1.Visible = false;
            }
        }

        private void passfield_Enter(object sender, EventArgs e)
        {
            passfield.Clear();
            passfield.UseSystemPasswordChar = true;
        }

       

        
    }
}
