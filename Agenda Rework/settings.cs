using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using MetroFramework;

namespace Agenda_Rework
{
    
    public partial class settings : MetroFramework.Forms.MetroForm
    {



        public static string conf_directory  =   @"d:\" + @"Agneda\" + LoginForm.current_user,
                             conf_file       =   conf_directory + @"\interface.conf";
        config conf = new config();




        public settings()
        {
            InitializeComponent();
        }




        private void settings_Load(object sender, EventArgs e)
        {
            //if the config file doesn't exist, load the dictionary with the 
            //configuration values and then dump them into interface.conf
            this.StyleManager = metroStyleManager1;
            if (!Directory.Exists(conf_directory)) { Directory.CreateDirectory(conf_directory); }
            if (!File.Exists(conf_file))
            {
                try
                {
                    using (FileStream fs = new FileStream(conf_file, FileMode.Create, FileAccess.Write))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        bf.Serialize(fs, conf);

                    }
                }
                catch (Exception err)
                {
                    MetroMessageBox.Show(this, "Could not create a configuration file.\nError:" + err.ToString(), "oops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            //if the file already exists, read and deserialize.

            using (FileStream fs = new FileStream(conf_file, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                conf = (config)bf.Deserialize(fs);
                metroStyleManager1.Style = (MetroFramework.MetroColorStyle)conf.style;


                //excuse the "if block".
                if (conf.Appointments) appoint_check.Checked = true;
                if (conf.self_study) slfstd_check.Checked = true;
                if (conf.todo) todo_check.Checked = true;
                if (conf.towatch) towatch_check.Checked = true;
                if (conf.uni_school) uni_check.Checked = true;
                if (conf.toread) tord_check.Checked = true;
            }
        }



        private void apply_btn_Click(object sender, EventArgs e)
        {//if the apply button gives you trouble then create the conf object outside then re-assign it here and up there
            try
            {
                using (FileStream fs = new FileStream(conf_file, FileMode.Truncate, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, conf);

                }
            }
            catch (Exception err)
            {
                MetroMessageBox.Show(this, "Could not write configuration to disk.\nError:" + err.ToString(), "oops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


       

        private void chgusr_Click(object sender, EventArgs e)
        {
            string contents = null;
            StreamReader srr = File.OpenText("Users.dat");
            contents = srr.ReadToEnd();
            string name = contents.Split('|')[0];
            srr.Close();
            StreamWriter sw = File.CreateText("Users.dat");
            sw.Write(contents.Replace(name, newusername.Text));
            sw.Close();
        }

        private void dltacct_Click(object sender, EventArgs e)
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

            MetroFramework.MetroMessageBox.Show(this, "We will miss you, " + myname + " 💔 ", "Bye..", MessageBoxButtons.OK);


        }


        private void oldbox_Enter(object sender, EventArgs e)
        {
            oldbox.Clear();
            oldbox.UseSystemPasswordChar = true;
        }

        private void newbox_Enter(object sender, EventArgs e)
        {
            newbox.Clear();
            newbox.UseSystemPasswordChar = true;
        }

        private void confirm_Enter(object sender, EventArgs e)
        {
            confirm.Clear();
            confirm.UseSystemPasswordChar = true;
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
           /**
            * 
            * w da kaman.
            * 
            * 
            * **/
            bool err_flag = false;

            if (newbox.Text != confirm.Text)
            {
                err_flag = true;
                MetroFramework.MetroMessageBox.Show(this, "Password Don't Match,Try Again...", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!err_flag)
            {
                string contents = "",
                       name = "",
                       gender = "";

                using (FileStream fs = new FileStream("Users.dat", FileMode.Open, FileAccess.ReadWrite))
                {

                    using (StreamReader sr = new StreamReader(fs))
                    {

                        contents = sr.ReadToEnd();

                    }
                }

                //search for the record and take it in memory for later reconstruction.
                foreach (var record in Regex.Split(contents, @"(?<=[;])"))
                {
                    if (record.Contains(LoginForm.current_user))
                    {

                        name = record.Split('|')[0];
                        gender = record.Split('|')[2];  //ALREADY CONTAINS ";" <------- 
                    }
                }
                //Now let's reconstruct that sucker!
                string new_record = newusername.Text.ToLower() + '|' + confirm.Text + '|' + gender;

                using (FileStream fs = new FileStream("Users.dat", FileMode.Truncate, FileAccess.Write))
                {


                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        foreach (var rec in Regex.Split(contents, @"(?<=[;])"))
                        {
                            if (rec.Contains(LoginForm.current_user)) { continue; } else { sw.Write(rec); }

                        }

                        sw.Write(new_record);

                    }
                }
            }
        }

        private void chgusr_Click_1(object sender, EventArgs e)
            /**
             * 
             * ELLY HAYEEGI GAMB EL BLOCK DA HA3AWARO 
             * 
             * **/
        {
            string contents="",
                   pass="",
                   gender="";

            using(FileStream fs = new FileStream("Users.dat",FileMode.Open,FileAccess.ReadWrite)){

                using (StreamReader sr = new StreamReader(fs)) {

                     contents = sr.ReadToEnd();

                }}
                    
                        //search for the record and take it in memory for later reconstruction.
                foreach (var record in Regex.Split(contents, @"(?<=[;])")) {
                    if (record.Contains(LoginForm.current_user)) {

                         pass = record.Split('|')[1];
                         gender = record.Split('|')[2];  //ALREADY CONTAINS ";" <------- 
                    }
                   }
                        //Now let's reconstruct that sucker!
                string new_record = newusername.Text.ToLower() + '|' + pass + '|' + gender;  

                using (FileStream fs = new FileStream("Users.dat",FileMode.Truncate,FileAccess.Write))
                {
                    
                
                using (StreamWriter sw = new StreamWriter(fs)) {
                    foreach (var rec in Regex.Split(contents, @"(?<=[;])")) {
                        if (rec.Contains(LoginForm.current_user)) { continue; } else { sw.Write(rec); }
                    
                    }

                    sw.Write(new_record);

                        }}

            
            
             
        }




        private void changepp_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //metroTile3.TileImage = Image.FromFile(ofd.FileName);


                //if a user directory doesn't exist:
                if (!Directory.Exists(@"D:\" + LoginForm.current_user))
                {
                    Directory.CreateDirectory(@"D:\" + LoginForm.current_user);

                }
                //if a config. file doesn't exist:
                if (!File.Exists(conf_file))
                {
                    File.Create(conf_file);
                }
                using (FileStream conf_fs = new FileStream(conf_file, FileMode.Open, FileAccess.ReadWrite))
                {
                    using (StreamWriter conf_sw = new StreamWriter(conf_fs))
                    {
                        //if file is empty
                        if (new FileInfo(conf_file).Length == 0)
                        {
                            string full_pp_path = Path.GetDirectoryName(ofd.FileName);
                            conf_sw.WriteLine("PP:" + full_pp_path);
                        }



                    }



                }

            }
        }

        private void appoint_check_CheckedChanged(object sender, EventArgs e)
        {
            if (!appoint_check.Checked) { conf.Appointments = false; } else { conf.Appointments = true; }
        }

        private void towatch_check_CheckedChanged(object sender, EventArgs e)
        {
            if (!towatch_check.Checked) { conf.towatch = false; } else { conf.towatch = true; }
        }

        private void todo_check_CheckedChanged(object sender, EventArgs e)
        {
            if (!todo_check.Checked) { conf.todo = false; } else { conf.todo = true; }
        }

        private void tord_check_CheckedChanged(object sender, EventArgs e)
        {
            if (!tord_check.Checked) { conf.toread = false; } else { conf.toread = true; }
        }

        private void slfstd_check_CheckedChanged(object sender, EventArgs e)
        {
            if (!slfstd_check.Checked) { conf.self_study = false; } else { conf.self_study = true; }
        }

        private void uni_check_CheckedChanged(object sender, EventArgs e)
        {
            if (!uni_check.Checked) { conf.uni_school = false; } else { conf.self_study = true; }
        }

        private void ForeColor_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)next;
            conf.style = (MetroFramework.MetroColorStyle)next;
        }


    }
}