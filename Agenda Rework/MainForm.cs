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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
       public string current_user="john",current_gender;
        public MainForm(string current_user, string current_gender)
        {
            this.current_user = current_user;
            this.current_gender = current_gender;
            InitializeComponent();
            GeneralSetting.Hide();
            AccountSettingButton.Hide();
            GeneralSettingButton.Hide();
         //   Accountsetting.Hide();
        }


        private void MainForm_Load_1(object sender, EventArgs e)
        {
            this.StyleManager = MSM1;
            label1.Text = System.DateTime.Now.DayOfWeek.ToString() + ", " + System.DateTime.Now.Day.ToString();
            MenuLabel.Text = "Welcome " + this.current_user;
            metroTile3.Text = this.current_user;
            /**
             * LOAD TILE PIC FROM CONFIG FILE HERE!
             * **/
        }

        private void metroTextButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = metroTile8.Text;
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = metroTile7.Text;
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = metroTile6.Text;
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = metroTile4.Text;
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = metroTile10.Text;
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = metroTile2.Text;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = metroTile1.Text;
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = metroTile9.Text;
            DetailsLabel.Hide();
            GeneralSetting.Show();
            AccountSettingButton.Show();
            GeneralSettingButton.Show();
            ////Accountsetting.Show();
        }

        private void GeneralSetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox1.Checked)
            {
                metroTile8.Enabled = false;
            }
            else
                metroTile8.Enabled = true;
        }

        private void metroCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox2.Checked)
            {
                metroTile7.Enabled = false;
            }
            else
                metroTile7.Enabled = true;
        }

        private void metroCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox3.Checked)
            {
                metroTile6.Enabled = false;
            }
            else
                metroTile6.Enabled = true;
        }

        private void metroCheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox4.Checked)
            {
                metroTile4.Enabled = false;
            }
            else
                metroTile4.Enabled = true;
        }

        private void metroCheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox5.Checked)
            {
                metroTile2.Enabled = false;
            }
            else
                metroTile2.Enabled = true;
        }

        private void metroCheckBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (metroCheckBox6.Checked)
            {
                metroTile1.Enabled = false;
            }
            else
                metroTile1.Enabled = true;
        }

        private void ForeColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                metroTile10.ForeColor = dialog.Color;
                metroTile9.ForeColor = dialog.Color;
                metroTile8.ForeColor = dialog.Color;
                metroTile7.ForeColor = dialog.Color;
                metroTile6.ForeColor = dialog.Color;
                metroTile5.ForeColor = dialog.Color;
                metroTile4.ForeColor = dialog.Color;
                metroTile3.ForeColor = dialog.Color;
                metroTile2.ForeColor = dialog.Color;
                metroTile1.ForeColor = dialog.Color;

            }
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            FontDialog fontdialogs = new FontDialog();
            if (fontdialogs.ShowDialog() == DialogResult.OK)
            {
                label1.Font = fontdialogs.Font;
                MenuLabel.Font = fontdialogs.Font;
                
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MSM1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(metroComboBox1.Text);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        { 
            var FD = new System.Windows.Forms.OpenFileDialog();
            FD.Filter = "png files|*.png";
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;

                System.IO.FileInfo File = new System.IO.FileInfo(FD.FileName);
                BackgroundImage = Image.FromFile(FD.FileName);
                string path = fileToOpen;
                Image myimage = new Bitmap(path);
                this.BackgroundImage = myimage;
            }
        }

        private void MenuLabel_Click(object sender, EventArgs e)
        {

        }

        private void GeneralSettingButton_Click(object sender, EventArgs e)
        {
            ////Accountsetting.Hide();
            GeneralSetting.Show();
        }

        private void Accountsetting_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccountSettingButton_Click(object sender, EventArgs e)
        {
            GeneralSetting.Hide();
            //Accountsetting.Show();
        }

        /**private void metroButton3_Click(object sender, EventArgs e)
        {
            string contents = null;
            StreamReader srr = File.OpenText("Users.dat");
            contents = srr.ReadToEnd();
            string name = contents.Split('|')[0];
            srr.Close();
            StreamWriter sw = File.CreateText("Users.dat");
            sw.Write(contents.Replace(name, ""));
            sw.Close();
        }**/

        private void metroButton5_Click(object sender, EventArgs e)
        {
           // if (newbox.Text!=confirm.Text)
            {
                MessageBox.Show("Password Don't Match,Try Again...");
            }
            string contents = null;
            StreamReader srr = File.OpenText("Users.dat");
            contents = srr.ReadToEnd();
            srr.Close();
            StreamWriter sw = File.CreateText("Users.dat");
            sw.Write(contents.Replace("",""));
            sw.Close();
        }

       
        OpenFileDialog ofd = new OpenFileDialog();
        private void changepp_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                metroTile3.TileImage = Image.FromFile(ofd.FileName);
            }
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            string myname = Microsoft.VisualBasic.Interaction.InputBox("Enter Your Username", "");
            StreamReader sr = new StreamReader("Users.dat");
            int countline = 0;
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                countline++;
                if (line.Contains(myname))
                {
                    break;
                }
            }
            sr.Close();

            string linee = null;
            int linenumber = 0;
            using (StreamReader reader = new StreamReader("Users.dat"))
            {
                using (StreamWriter writer = new StreamWriter("new.dat"))
                {
                    while ((linee = reader.ReadLine()) != null)
                    {
                        linenumber++;
                        if (linenumber == countline)
                        {
                            continue;
                        }
                        writer.WriteLine(linee);
                    }
                }
            }
            File.Delete("Users.dat");
            File.Move("new.dat", "Users.dat");

            MetroFramework.MetroMessageBox.Show(this, "We will miss you, "+myname+ " 💔", "Bye..", MessageBoxButtons.OK);

           
        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel12_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel11_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {

        }

        private void newbox_Click(object sender, EventArgs e)
        {

        }

        private void oldbox_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void newusername_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

     

        

  
    }
    public enum MetroColorStyle
    {
        Default =0,
        Black=1,
        White=2,
        Silver=3,
        Blue=4,
        Green=5,
        Lime=6,
        Teal=7,
        Orange=8,
        Brown=9,
        Pink=10,
        Magenta=11,
        Purple=12,
        Red=13,
        Yellow=14,
    
    
    
    }
}
