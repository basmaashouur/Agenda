using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using System.IO;
using WMPLib;
using System.Diagnostics;

namespace Agenda_Rework
{
    public partial class Zenzone : MetroFramework.Forms.MetroForm
    {
        DirectoryInfo files;
        List<string> fileswithextension = new List<string>();
        bool list_empty = true;
        string exe_path,new_path;

        public Zenzone()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            DialogResult res = MetroFramework.MetroMessageBox.Show(this, "Continuing will entirely disable your internet connection,\nAre you sure you want to continue?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes) { Process.Start("ipconfig", "/release"); metroTile4.Visible = true; playtile.Visible = false; pausetile.Visible = false; }
            metroComboBox1.Visible = false;
            metroButton1.Visible = false;
            unblk_button.Visible = false;
            metroTrackBar1.Visible = false;
            
        }

        private void Zenzone_Load(object sender, EventArgs e)
        {
            if(!Directory.Exists("Data"))Directory.CreateDirectory("Data");
            try
            {
                files = new DirectoryInfo("stations");
                
            }
            catch (Exception) { MetroFramework.MetroMessageBox.Show(this, "Stations file not found it was empty, Audio bubble will not be available.", "oops..", MessageBoxButtons.OK, MessageBoxIcon.Error);
            metroTile3.Enabled = false;

            }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroTile4.Visible = false;
            metroButton1.Visible = false;
            unblk_button.Visible = false;
            metroComboBox1.Visible = true;
            textBox1.Text = "Audio bubble protects you from any auditory disctractions that may \nbe happening         around you.\n you may pick a track from the list below and it will start playing \n                (Note: Requires Internet Connection.) ";
            if (list_empty)
            {
                foreach (var station in files.GetFiles())
                {
                    metroComboBox1.Items.Add(station.ToString().Split('.')[0]);
                    fileswithextension.Add(station.ToString());


                } list_empty = false;
            }

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                wmp.URL = "stations/" + fileswithextension[metroComboBox1.SelectedIndex];
            }
            catch (Exception) { MetroMessageBox.Show(this,"Station cannot be played, Please make sure you have a stable internet connection.","oops..",MessageBoxButtons.OK,MessageBoxIcon.Error); }
            metroProgressSpinner1.Visible = true;
            
                    }

        private void wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
                    
            if (wmp.playState == WMPPlayState.wmppsPlaying)
            {
                metroProgressSpinner1.Visible = false;
                playtile.Visible = true;
                pausetile.Visible = true;
                metroTrackBar1.Visible = true;
            }
        }

        private void pausetile_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.pause();
        }

        private void playtile_Click(object sender, EventArgs e)
        {
            wmp.Ctlcontrols.play();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Process.Start("ipconfig", "/renew");
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            metroButton1.Visible = true;
            metroTile4.Visible = false;
            metroComboBox1.Visible = false;
            metroTrackBar1.Visible = false;
            textBox1.Text = "Application Blocker helps you to stop applications that distract you during your work sessions from working until you turn them back on, choose the path of the application from the button below to start blocking.";

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            DialogResult dr = of.ShowDialog();
            if (dr != DialogResult.Cancel)
            {
                exe_path = of.FileName;
                if (exe_path.Contains(".exe"))
                {
                    try
                    {
                        File.Move(exe_path, @"Data/625");
                        metroButton1.Visible = false;
                        unblk_button.Visible = true;
                    }
                    catch (Exception err) { MetroFramework.MetroMessageBox.Show(this, "Application Can't be blocked.\n"+err.Message.ToString(), "oops..", MessageBoxButtons.OK, MessageBoxIcon.Error); }


                }
                else { MetroFramework.MetroMessageBox.Show(this, "File must be an application (.exe)", "oops..", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void unblk_button_Click(object sender, EventArgs e)
        {
            File.Move(@"Data/625", exe_path);
            unblk_button.Visible = false;
            metroButton1.Visible = true;
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            wmp.settings.volume = metroTrackBar1.Value;
        }

        
       

       
    }
}
