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
    public partial class Signup : MetroFramework.Forms.MetroForm
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            metroTextBox1.Clear();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            pass1.Clear();
            pass1.UseSystemPasswordChar = true;
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            pass2.Clear();
            pass2.UseSystemPasswordChar = true;

        }

        private void metroTextBox3_Leave(object sender, EventArgs e)
        {
            if(pass1.Text != pass2.Text){
                metroLabel7.Text = "Sorry, Passwords Don't match.";
            }
        }

        
    }
}
