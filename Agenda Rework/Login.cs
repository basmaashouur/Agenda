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
            if (File.Exists("Users.dat"))
            {


                bool found_flag = false;
                using (FileStream fs = new FileStream("Users.dat", FileMode.Open, FileAccess.Read))
                {
                    string username, pass, gender = "";
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string contents = sr.ReadToEnd();

                        foreach(var record in contents.Split(';'))
                        {
                            try
                            {
                                username = record.Split('|')[0];
                                pass = record.Split('|')[1];
                                gender = record.Split('|')[2];


                                if (username == Unamefield.Text.ToLower() && pass == passfield.Text)
                                {
                                    found_flag = true;
                                    current_user = username;
                                    current_password = pass;
                                    current_gender = gender;
                                    metroProgressSpinner1.Visible = true;
                                    timer1.Enabled = true;
                                    timer1.Start();
                                    /**MFthread MFT = new MFthread();
                                    Thread th = new Thread(new ThreadStart(MFT.ShowMain));
                                    th.Start();**/
                                    settings st = new settings();
                                    st.Show();
                                    this.Hide();
                                    break;

                                }
                                else { found_flag = false; }

                            }
                            catch { found_flag = false; }

                        }
                        if (!found_flag) { MetroFramework.MetroMessageBox.Show(this, "Wrong username or password.", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Visible = false;
                        metroProgressSpinner1.Visible = false;
                        }


                    }
                }









            }
            else { MetroFramework.MetroMessageBox.Show(this, "Database is empty, Please create at least one account first.", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);}
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
            if (i == 5) { timer1.Stop(); }

        }

       

       

        
    }
}
