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
        public string current_user, current_gender;
        public MainForm(string current_user, string current_gender)
        {
            this.current_user = current_user;
            this.current_gender = current_gender;
            InitializeComponent();

        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            MFthread.load_flag = true;
            using (FileStream fs = new FileStream(settings.conf_file, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                config conf = (config)bf.Deserialize(fs);
                MSM1.Style = (MetroFramework.MetroColorStyle)conf.style;
                this.StyleManager = MSM1;
                label1.Text = System.DateTime.Now.DayOfWeek.ToString() + ", " + System.DateTime.Now.Day.ToString();
                MenuLabel.Text = "Welcome " + LoginForm.current_user;
                metroTile3.Text = LoginForm.current_user;
                if (!conf.Appointments) { Appoint_tile.Enabled = false; } 
                if (!conf.self_study) { Selfstd_tile.Enabled   = false; }
                if (!conf.towatch) { towatch_tile.Enabled = false; } else { towatch_tile.Enabled = true; }
                if (!conf.uni_school) { uni_tile.Enabled = false; }
                if (!conf.toread) { toread_tile.Enabled = false; }
                if (!conf.todo) { todo_tile.Enabled = false; }
            }
        }




        /*
           #START OF BASMA'S STUFF *DONT EDIT, TOUCH OR DONT EVEN LOOK!* 
             */


        private void metroTile1_Click(object sender, EventArgs e)
        {
            // uni.school     ((0))

            WriteStuff ein = new WriteStuff();
            ein.LabelText = this.uni_tile.Text;
            ein.TodowriteText = "Add a to-do in unvirsity and school..";
            string[] stuffUni = { "Project", "Read", "Task", "Tutorial", "Other" };
            ein.gendre.Items.AddRange(stuffUni);
            ein.gendre.SelectedIndex = 4;
            // start of handling the file and showing the perv stuff
            FileStream school = new FileStream("school.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader powersc = new StreamReader(school);
            string ninja;
            while (true)
            {
                ninja = powersc.ReadLine();
                if (ninja == null) break;
                Label lb = new Label();
                Point p = new Point(0, 30 * ein.posSch);
                lb.Location = p;
                lb.Size = new Size(1000, 20);
                lb.Text = ninja;
                lb.ForeColor = System.Drawing.Color.Gray;
                ein.finalto.Controls.Add(lb);
                ein.posSch++;
            }// end of handling and showing the perv stuff in the file
            powersc.Close();
            school.Close();
            ein.todoPanel.Hide();
            ein.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            //selfstudy   ((1))

            WriteStuff ein = new WriteStuff();
            ein.LabelText = this.Selfstd_tile.Text;
            ein.TodowriteText = "Add a to-do in self study..";
            string[] stuffself = { "Practice", "Project", "Read", "Task", "Tutorial", "Other" };
            ein.gendre.Items.AddRange(stuffself);
            ein.gendre.SelectedIndex = 5;
            // start of handling the file and showing the perv stuff
            FileStream selfstudy = new FileStream("selfstudy.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader powerse = new StreamReader(selfstudy);
            string ninja;
            while (true)
            {
                ninja = powerse.ReadLine();
                if (ninja == null) break;
                Label lb = new Label();
                Point p = new Point(0, 30 * ein.posSelf);
                lb.Location = p;
                lb.Size = new Size(1000, 20);
                lb.Text = ninja;
                lb.ForeColor = System.Drawing.Color.Gray;
                ein.finalto.Controls.Add(lb);
                ein.posSelf++;
            }// end of handling and showing the perv stuff in the file
            powerse.Close();
            selfstudy.Close();
            ein.todoPanel.Hide();
            ein.Show();
        }


        private void metroTile4_Click(object sender, EventArgs e)
        {
            //to read   ((2))

            WriteStuff ein = new WriteStuff();
            ein.LabelText = this.toread_tile.Text;
            ein.TodowriteText = "Add a to-do in to-read..";
            string[] stuffself = { "Article", "Blog", "Comic", "Magazine", "Manga", "Novel", "Scientfic", "Other" };
            ein.gendre.Items.AddRange(stuffself);
            ein.gendre.SelectedIndex = 7;
            // start of handling the file and showing the perv stuff
            FileStream toread = new FileStream("toread.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader powertre = new StreamReader(toread);
            string ninja;
            while (true)
            {
                ninja = powertre.ReadLine();
                if (ninja == null) break;
                Label lb = new Label();
                Point p = new Point(0, 30 * ein.posRe);
                lb.Location = p;
                lb.Size = new Size(1000, 20);
                lb.Text = ninja;
                lb.ForeColor = System.Drawing.Color.Gray;
                ein.finalto.Controls.Add(lb);
                ein.posRe++;
            }// end of handling and showing the perv stuff in the file
            powertre.Close();
            toread.Close();
            ein.todoPanel.Hide();
            ein.Show();

        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            //to watch    ((3))

            WriteStuff ein = new WriteStuff();
            ein.LabelText = this.towatch_tile.Text;
            ein.TodowriteText = "Add a to-do in to-watch..";
            string[] stuffself = { "Anime", "Cartoon", "Documentary", "Movie", "Series", "Tutorial", "Other" };
            ein.gendre.Items.AddRange(stuffself);
            ein.gendre.SelectedIndex = 6;
            // start of handling the file and showing the perv stuff
            FileStream towatch = new FileStream("towatch.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader powerwa = new StreamReader(towatch);
            string ninja;
            while (true)
            {
                ninja = powerwa.ReadLine();
                if (ninja == null) break;
                Label lb = new Label();
                Point p = new Point(0, 30 * ein.posWa);
                lb.Location = p;
                lb.Size = new Size(1000, 20);
                lb.Text = ninja;
                lb.ForeColor = System.Drawing.Color.Gray;
                ein.finalto.Controls.Add(lb);
                ein.posWa++;
            }// end of handling and showing the perv stuff in the file
            powerwa.Close();
            towatch.Close();
            ein.todoPanel.Hide();
            ein.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            //appoiments    ((4))

            WriteStuff ein = new WriteStuff();
            ein.LabelText = this.Appoint_tile.Text;
            ein.TodowriteText = "Add a to-do in appoiments..";
            string[] stuffself = { "Family", "Job", "Social", "Study", "Other" };
            ein.gendre.Items.AddRange(stuffself);
            ein.gendre.SelectedIndex = 4;
            // start of handling the file and showing the perv stuff
            FileStream appoim = new FileStream("appoiments.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader powerapp = new StreamReader(appoim);
            string ninja;
            while (true)
            {
                ninja = powerapp.ReadLine();
                if (ninja == null) break;
                Label lb = new Label();
                Point p = new Point(0, 30 * ein.posApp);
                lb.Location = p;
                lb.Size = new Size(1000, 20);
                lb.Text = ninja;
                lb.ForeColor = System.Drawing.Color.Gray;
                ein.finalto.Controls.Add(lb);
                ein.posApp++;
            }// end of handling and showing the perv stuff in the file
            powerapp.Close();
            appoim.Close();
            ein.todoPanel.Hide();
            ein.allPanel.Show();
            ein.Show();

        }
        private void metroTile6_Click(object sender, EventArgs e)
        {
            //to-do
            WriteStuff ein = new WriteStuff();
            ein.LabelText = this.todo_tile.Text;
            // start of handling and showing the perv stuff in the file
            FileStream todo = new FileStream("todo.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader powertodo = new StreamReader(todo);
            string ninja;
            while (true)
            {
                ninja = powertodo.ReadLine();
                if (ninja == null) break;
                CheckBox ch = new CheckBox();
                Point p = new Point(0, 60 * ein.posTodo);
                ch.Location = p;
                ch.Size = new Size(1000, 20);
                ch.Text = ninja;
                ch.ForeColor = System.Drawing.Color.Gray;
                ein.todoPanel.Controls.Add(ch);
                ein.posTodo++;
            }// end of handling and showing the perv stuff in the file
            powertodo.Close();
            todo.Close();
            ein.Show();
        }


        /*
        END OF BASMA'S STUFF!
          */




        private void metroTextButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }


        private void metroTile3_Click(object sender, EventArgs e)
        {
            metroTile1.Visible = true;
            metroTile2.Visible = true;

        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = metroTile10.Text;
            Zenzone zz = new Zenzone();
            zz.Show();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            MenuLabel.Text = metroTile9.Text;
            settings st = new settings();
            st.Show();

        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {
            metroTile1.Visible = false;
            metroTile2.Visible = false;
        }

 



      
   



    }
}
