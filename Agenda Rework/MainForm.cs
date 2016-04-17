using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda_Rework
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
          
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.StyleManager = MSM1;
            label1.Text = System.DateTime.Now.DayOfWeek.ToString() + ", " + System.DateTime.Now.Day.ToString();

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
        }

       
    }
}
