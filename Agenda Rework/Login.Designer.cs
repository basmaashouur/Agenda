namespace Agenda_Rework
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.Unamefield = new MetroFramework.Controls.MetroTextBox();
            this.NewuserButton = new MetroFramework.Controls.MetroButton();
            this.passfield = new MetroFramework.Controls.MetroTextBox();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.loadinglabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 30.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agenda";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 141);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.ForeColor = System.Drawing.Color.White;
            this.metroLabel1.Location = new System.Drawing.Point(158, 288);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Login";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(107, 404);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 9;
            this.LoginButton.Text = "Login";
            this.LoginButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LoginButton.UseSelectable = true;
            this.LoginButton.UseStyleColors = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Unamefield
            // 
            this.Unamefield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.Unamefield.CustomButton.Image = null;
            this.Unamefield.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.Unamefield.CustomButton.Name = "";
            this.Unamefield.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Unamefield.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Unamefield.CustomButton.TabIndex = 1;
            this.Unamefield.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Unamefield.CustomButton.UseSelectable = true;
            this.Unamefield.CustomButton.Visible = false;
            this.Unamefield.Lines = new string[] {
        "Username"};
            this.Unamefield.Location = new System.Drawing.Point(116, 326);
            this.Unamefield.MaxLength = 32767;
            this.Unamefield.Name = "Unamefield";
            this.Unamefield.PasswordChar = '\0';
            this.Unamefield.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Unamefield.SelectedText = "";
            this.Unamefield.SelectionLength = 0;
            this.Unamefield.SelectionStart = 0;
            this.Unamefield.Size = new System.Drawing.Size(136, 23);
            this.Unamefield.TabIndex = 7;
            this.Unamefield.Text = "Username";
            this.Unamefield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Unamefield.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Unamefield.UseSelectable = true;
            this.Unamefield.UseStyleColors = true;
            this.Unamefield.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Unamefield.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.Unamefield.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // NewuserButton
            // 
            this.NewuserButton.Location = new System.Drawing.Point(188, 404);
            this.NewuserButton.Name = "NewuserButton";
            this.NewuserButton.Size = new System.Drawing.Size(75, 23);
            this.NewuserButton.TabIndex = 5;
            this.NewuserButton.Text = "New User";
            this.NewuserButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.NewuserButton.UseSelectable = true;
            this.NewuserButton.UseStyleColors = true;
            this.NewuserButton.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // passfield
            // 
            this.passfield.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // 
            // 
            this.passfield.CustomButton.Image = null;
            this.passfield.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.passfield.CustomButton.Name = "";
            this.passfield.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passfield.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passfield.CustomButton.TabIndex = 1;
            this.passfield.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passfield.CustomButton.UseSelectable = true;
            this.passfield.CustomButton.Visible = false;
            this.passfield.Lines = new string[] {
        "Password"};
            this.passfield.Location = new System.Drawing.Point(116, 355);
            this.passfield.MaxLength = 32767;
            this.passfield.Name = "passfield";
            this.passfield.PasswordChar = '\0';
            this.passfield.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passfield.SelectedText = "";
            this.passfield.SelectionLength = 0;
            this.passfield.SelectionStart = 0;
            this.passfield.Size = new System.Drawing.Size(136, 23);
            this.passfield.TabIndex = 8;
            this.passfield.Text = "Password";
            this.passfield.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passfield.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.passfield.UseSelectable = true;
            this.passfield.UseStyleColors = true;
            this.passfield.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passfield.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passfield.Enter += new System.EventHandler(this.passfield_Enter);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(124, 484);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(123, 37);
            this.metroProgressSpinner1.TabIndex = 10;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.Visible = false;
            // 
            // loadinglabel
            // 
            this.loadinglabel.AutoSize = true;
            this.loadinglabel.Location = new System.Drawing.Point(147, 449);
            this.loadinglabel.Name = "loadinglabel";
            this.loadinglabel.Size = new System.Drawing.Size(77, 19);
            this.loadinglabel.TabIndex = 11;
            this.loadinglabel.Text = "Logging in..";
            this.loadinglabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loadinglabel.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 549);
            this.Controls.Add(this.loadinglabel);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.passfield);
            this.Controls.Add(this.NewuserButton);
            this.Controls.Add(this.Unamefield);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroTextBox Unamefield;
        private MetroFramework.Controls.MetroButton NewuserButton;
        private MetroFramework.Controls.MetroTextBox passfield;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroLabel loadinglabel;
    }
}