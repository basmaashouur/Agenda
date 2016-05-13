using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Agenda_Rework
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
       public string current_user,current_gender;
        public MainForm()
        {
            this.current_user = LoginForm.current_user;
            this.current_gender = LoginForm.current_gender;
            InitializeComponent();
            
        }


        private void MainForm_Load_1(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(settings.conf_file, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                config conf = (config)bf.Deserialize(fs);
                MSM1.Style = (MetroFramework.MetroColorStyle)conf.style;
            }
            this.StyleManager = MSM1;
            label1.Text = System.DateTime.Now.DayOfWeek.ToString() + ", " + System.DateTime.Now.Day.ToString();
            MenuLabel.Text = "Welcome " + this.current_user;
            metroTile3.Text = this.current_user;
            /**
             * LOAD TILE PIC FROM CONFIG FILE HERE!
             * **/
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
            DetailsLabel.Text = "ZenZone puts you in your own private distractions-free bubble";
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
        }

        private void GeneralSetting_Paint(object sender, PaintEventArgs e)
        {

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

  
    }

}