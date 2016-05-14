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
    public partial class splash : MetroFramework.Forms.MetroForm
    {
        int i = 0;
        public splash()
        {
            InitializeComponent();
        }

        private void splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += .1;
            if (this.Opacity == 1) {
                timer1.Stop();
                timer2.Enabled = true;
                timer2.Start();
                
            
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 10)
            {   
                timer2.Stop();
                timer3.Enabled = true;
                timer3.Start();
                
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (i == 0) {
                timer3.Stop();
                this.Hide();
                LoginForm lf = new LoginForm();
                lf.Show();
            
            }
            this.Opacity -= .1;
            i--;
        }
    }
}
