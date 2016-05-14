namespace Agenda_Rework
{
    partial class WriteStuff
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
            this.components = new System.ComponentModel.Container();
            this.writeA = new MetroFramework.Controls.MetroTextBox();
            this.gendre = new MetroFramework.Controls.MetroComboBox();
            this.Add = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.labelOf = new MetroFramework.Controls.MetroLabel();
            this.finalto = new MetroFramework.Controls.MetroPanel();
            this.allPanel = new MetroFramework.Controls.MetroPanel();
            this.todoPanel = new MetroFramework.Controls.MetroPanel();
            this.deletechecked = new MetroFramework.Controls.MetroButton();
            this.MSM = new MetroFramework.Components.MetroStyleManager(this.components);
            this.allPanel.SuspendLayout();
            this.todoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MSM)).BeginInit();
            this.SuspendLayout();
            // 
            // writeA
            // 
            this.writeA.BackColor = System.Drawing.Color.Black;
            // 
            // 
            // 
            this.writeA.CustomButton.Image = null;
            this.writeA.CustomButton.Location = new System.Drawing.Point(617, 1);
            this.writeA.CustomButton.Name = "";
            this.writeA.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.writeA.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.writeA.CustomButton.TabIndex = 1;
            this.writeA.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.writeA.CustomButton.UseSelectable = true;
            this.writeA.CustomButton.Visible = false;
            this.writeA.ForeColor = System.Drawing.Color.Transparent;
            this.writeA.Lines = new string[] {
        "Write a to-do.."};
            this.writeA.Location = new System.Drawing.Point(140, 15);
            this.writeA.MaxLength = 32767;
            this.writeA.Name = "writeA";
            this.writeA.PasswordChar = '\0';
            this.writeA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.writeA.SelectedText = "";
            this.writeA.SelectionLength = 0;
            this.writeA.SelectionStart = 0;
            this.writeA.Size = new System.Drawing.Size(639, 23);
            this.writeA.TabIndex = 0;
            this.writeA.Text = "Write a to-do..";
            this.writeA.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.writeA.UseSelectable = true;
            this.writeA.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.writeA.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.writeA.Click += new System.EventHandler(this.writeA_click);
            // 
            // gendre
            // 
            this.gendre.FormattingEnabled = true;
            this.gendre.ItemHeight = 23;
            this.gendre.Location = new System.Drawing.Point(353, 54);
            this.gendre.Name = "gendre";
            this.gendre.Size = new System.Drawing.Size(200, 29);
            this.gendre.TabIndex = 1;
            this.gendre.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.gendre.UseSelectable = true;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Add.Image = null;
            this.Add.Location = new System.Drawing.Point(424, 105);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 31);
            this.Add.Style = MetroFramework.MetroColorStyle.Silver;
            this.Add.TabIndex = 2;
            this.Add.Text = "Add";
            this.Add.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Add.UseSelectable = true;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // labelOf
            // 
            this.labelOf.AutoSize = true;
            this.labelOf.BackColor = System.Drawing.Color.Transparent;
            this.labelOf.Location = new System.Drawing.Point(23, 14);
            this.labelOf.Name = "labelOf";
            this.labelOf.Size = new System.Drawing.Size(37, 19);
            this.labelOf.TabIndex = 3;
            this.labelOf.Text = "label";
            this.labelOf.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelOf.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // finalto
            // 
            this.finalto.HorizontalScrollbarBarColor = true;
            this.finalto.HorizontalScrollbarHighlightOnWheel = false;
            this.finalto.HorizontalScrollbarSize = 10;
            this.finalto.Location = new System.Drawing.Point(140, 158);
            this.finalto.Name = "finalto";
            this.finalto.Size = new System.Drawing.Size(639, 290);
            this.finalto.TabIndex = 4;
            this.finalto.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.finalto.VerticalScrollbarBarColor = true;
            this.finalto.VerticalScrollbarHighlightOnWheel = false;
            this.finalto.VerticalScrollbarSize = 10;
            this.finalto.Paint += new System.Windows.Forms.PaintEventHandler(this.finalto_Paint);
            // 
            // allPanel
            // 
            this.allPanel.Controls.Add(this.todoPanel);
            this.allPanel.Controls.Add(this.finalto);
            this.allPanel.Controls.Add(this.writeA);
            this.allPanel.Controls.Add(this.Add);
            this.allPanel.Controls.Add(this.gendre);
            this.allPanel.HorizontalScrollbarBarColor = true;
            this.allPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.allPanel.HorizontalScrollbarSize = 10;
            this.allPanel.Location = new System.Drawing.Point(23, 82);
            this.allPanel.Name = "allPanel";
            this.allPanel.Size = new System.Drawing.Size(943, 481);
            this.allPanel.TabIndex = 5;
            this.allPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.allPanel.VerticalScrollbarBarColor = true;
            this.allPanel.VerticalScrollbarHighlightOnWheel = false;
            this.allPanel.VerticalScrollbarSize = 10;
            this.allPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // todoPanel
            // 
            this.todoPanel.Controls.Add(this.deletechecked);
            this.todoPanel.HorizontalScrollbarBarColor = true;
            this.todoPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.todoPanel.HorizontalScrollbarSize = 10;
            this.todoPanel.Location = new System.Drawing.Point(0, 3);
            this.todoPanel.Name = "todoPanel";
            this.todoPanel.Size = new System.Drawing.Size(943, 475);
            this.todoPanel.TabIndex = 5;
            this.todoPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.todoPanel.VerticalScrollbarBarColor = true;
            this.todoPanel.VerticalScrollbarHighlightOnWheel = false;
            this.todoPanel.VerticalScrollbarSize = 10;
            this.todoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel2_Paint);
            // 
            // deletechecked
            // 
            this.deletechecked.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.deletechecked.Location = new System.Drawing.Point(396, 24);
            this.deletechecked.Name = "deletechecked";
            this.deletechecked.Size = new System.Drawing.Size(151, 32);
            this.deletechecked.TabIndex = 2;
            this.deletechecked.Text = "Delete Checked";
            this.deletechecked.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.deletechecked.UseSelectable = true;
            this.deletechecked.Click += new System.EventHandler(this.deletechecked_Click);
            // 
            // MSM
            // 
            this.MSM.Owner = this;
            this.MSM.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // WriteStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 587);
            this.Controls.Add(this.allPanel);
            this.Controls.Add(this.labelOf);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "WriteStuff";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.WriteStuff_Load);
            this.allPanel.ResumeLayout(false);
            this.todoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MSM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox.MetroTextButton Add;
        public MetroFramework.Controls.MetroComboBox gendre;
        public MetroFramework.Controls.MetroPanel finalto;
        private MetroFramework.Controls.MetroTextBox writeA;
        private MetroFramework.Controls.MetroLabel labelOf;
        public MetroFramework.Controls.MetroPanel allPanel;
        public MetroFramework.Controls.MetroPanel todoPanel;
        private MetroFramework.Controls.MetroButton deletechecked;
        private MetroFramework.Components.MetroStyleManager MSM;

    }
}