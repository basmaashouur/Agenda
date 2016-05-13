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

namespace Agenda_Rework
{
    
    public partial class settings : MetroFramework.Forms.MetroForm
    {



        public static string 
                             conf_directory  =   @"d:\" + @"Agneda\" + LoginForm.current_user,
                             conf_file       =   conf_directory + @"\interface.conf";
        public static Dictionary<string, int> conf = new Dictionary<string, int>(); 




        public settings()
        {
            InitializeComponent();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            //if the config file doesn't exist, load the dictionary with the 
            //configuration values and then dump them into interface.conf
            if (!Directory.Exists(conf_directory)) { Directory.CreateDirectory(conf_directory); }

          if(!File.Exists(conf_file)){
                conf.Add("Appointments",1);
                conf.Add("todo",1);
                conf.Add("uni_school",1);
                conf.Add("self_study", 1);
                conf.Add("towatch", 1);
                conf.Add("toread", 1);
                using (StreamWriter sr = new StreamWriter(conf_file)) {

                    foreach (KeyValuePair<string, int> kvp2 in conf)
                    {
                        sr.Write(kvp2.Key + "=" + kvp2.Value + ";\n");
                    }
                        conf.Clear();
                    }}


            //if the file already exists load the configuration from it into the dictionary;
          using (FileStream fs = new FileStream(conf_file, FileMode.Open, FileAccess.Read)) {
              using (StreamReader sr = new StreamReader(fs)) {
                  string line = sr.ReadLine();
                  while (line != null) {
                      conf.Add(line.Split('=')[0],int.Parse(line.Split(':')[1]));
                      line = sr.ReadLine();                  
                  }
              }
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
            string new_record;


            if (newbox.Text != confirm.Text)
            {

                MetroFramework.MetroMessageBox.Show(this, "Password Don't Match,Try Again...", "oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FileStream fs = new FileStream("Users.dat", FileMode.Open, FileAccess.ReadWrite);
            //Read all into "contents"
            StreamReader sr = new StreamReader(fs);
            string contents = sr.ReadToEnd();
            sr.Close();
            //search for the wanted line

            fs.Close();
            //reconstruct record
            if (new FileInfo("Users.dat").Length == 0)
            {
                 new_record = LoginForm.current_user + '|' + confirm.Text + '|' + LoginForm.current_gender + '\n';
            }
            else {  new_record = '\n'+LoginForm.current_user + '|' + confirm.Text + '|' + LoginForm.current_gender; }

            //Write new record along with the rest of them with an exception of the old one:
            File.Delete("Users.dat");
            StreamWriter sw = new StreamWriter("Users.dat");
            sw.Write(new_record);

            for (int i = 0; i < contents.Split('\n').Length; i++)
            {
                if (!(contents.Split('\n')[i].Contains(LoginForm.current_user))) { sw.Write(contents.Split('\n')[i] + '\n'); } else { continue; }
            }

            sw.Close();
        }

        private void chgusr_Click_1(object sender, EventArgs e)
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

        string config_string = "";

        private void appoint_check_CheckedChanged(object sender, EventArgs e)
        {
            if (appoint_check.Checked)
            {
                conf["Appointments"] = 1;

            }
            else { conf["Appointments"] = 0; }
        }

        private void towatch_check_CheckedChanged(object sender, EventArgs e)
        {
            if (towatch_check.Checked)
            {
                conf["towatch"] = 1;

            }
            else { conf["towatch"] = 0; }
        }

        private void todo_check_CheckedChanged(object sender, EventArgs e)
        {
            if (todo_check.Checked)
            {
                conf["todo"] = 1;

            }
            else { conf["todo"] = 0; }
        }

        private void tord_check_CheckedChanged(object sender, EventArgs e)
        {
            if (tord_check.Checked)
            {
                conf["toread"] = 1;

            }
            else { conf["toread"] = 1; }
        }

        private void slfstd_check_CheckedChanged(object sender, EventArgs e)
        {
            if (slfstd_check.Checked)
            {
                conf["self_study"] = 1;

            }
            else { conf["self_study"] = 1; }
        }

        private void uni_check_CheckedChanged(object sender, EventArgs e)
        {
            if (uni_check.Checked)
            {
                conf["uni_school"] = 1;

            }
            else { conf["uni_school"] = 1; }
        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void ForeColor_Click(object sender, EventArgs e)
        {

        }




    }
}