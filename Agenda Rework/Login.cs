using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Agenda_Rework
{

    


    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public static bool errflag;
        public static string current_user, current_password, current_gender;
        int i = 0;
        string[] loading_text = { "Logging in...",
                                  "Watering the garden...", 
                                  "Feeding the squirrels...", 
                                  "Painting the sky...", 
                                  "Doing something unnecessary...", 
                                  "You're awesome for waiting for so long!" };
        

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
            bool found_flag = false;
            if (File.Exists("Users.dat"))
            {
                FileStream login_fs = new FileStream("Users.dat", FileMode.Open, FileAccess.Read);
                StreamReader login_sr = new StreamReader(login_fs);

                string record = login_sr.ReadLine();
                while (record != null)
                {
                     current_user = record.Split('|')[0];
                     current_password = record.Split('|')[1];
                     current_gender = record.Split('|')[2];
                    if (current_user.ToLower() == Unamefield.Text.ToLower() && current_password == passfield.Text)
                    {
                        found_flag = true;
                        
                        metroProgressSpinner1.Visible = true;
                        timer1.Enabled = true;
                        timer1.Start();
                        MFthread MFT = new MFthread();
                        Thread TX = new Thread(new ThreadStart(MFT.ShowMain));
                        TX.Start();
                        break;
                    }
                    record = login_sr.ReadLine();
                    
                }
                if (!found_flag) { MetroFramework.MetroMessageBox.Show(this, "Wrong username or password.", "Oops..", MessageBoxButtons.OK,MessageBoxIcon.Error); }
          
                

            }
            else {
                MetroFramework.MetroMessageBox.Show(this, "Database is empty, Please create at least 1 account first.", "First time?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void passfield_Enter(object sender, EventArgs e)
        {
            
            passfield.Clear();
            passfield.UseSystemPasswordChar = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MFthread.load_flag == true) { this.Close(); timer1.Stop(); }
            
            textBox1.Text = loading_text[i];
            i++;
            if (i == 6) { timer1.Stop(); }

        }

       

       

        
    }
}
