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
        bool errflag = false;

        public class loadingthread
        {

         /**   public void showmain()
            {

                MainForm MF = new MainForm(user,);
                MF.Show();

            }**/

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
            bool found_flag = false;
            if (File.Exists("Users.dat"))
            {
                FileStream login_fs = new FileStream("Users.dat", FileMode.Open, FileAccess.Read);
                StreamReader login_sr = new StreamReader(login_fs);

                string record = login_sr.ReadLine();
                while (record != null)
                {
                    string current_user = record.Split('|')[0];
                    string current_password = record.Split('|')[1];
                    string current_gender = record.Split('|')[2];
                    if (current_user.ToLower() == Unamefield.Text.ToLower() && current_password == passfield.Text)
                    {
                        found_flag = true;
                        MainForm MF = new MainForm(current_user, current_gender);
                        MF.Show();
                        this.Hide();
                        break;
                    }
                    record = login_sr.ReadLine();
                    
                }
<<<<<<< HEAD

                login_fs.Close();
                login_sr.Close();
=======
                if (!found_flag) { MetroFramework.MetroMessageBox.Show(this, "Wrong username or password.", "Oops..", MessageBoxButtons.OK); }
          
                
>>>>>>> f9d8cd3e06baa2a54f0c82d5b3373435776747ee

            }
            else {
             MetroFramework.MetroMessageBox.Show(this,"Database is empty, Please create at least 1 account first.","First time?",MessageBoxButtons.OK);
            
            }
        }

        private void passfield_Enter(object sender, EventArgs e)
        {
            passfield.Clear();
            passfield.UseSystemPasswordChar = true;
        }

       

       

        
    }
}
