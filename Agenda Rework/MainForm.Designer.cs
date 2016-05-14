using System.Drawing;
namespace Agenda_Rework
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.uni_tile = new MetroFramework.Controls.MetroTile();
            this.Selfstd_tile = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.toread_tile = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            this.towatch_tile = new MetroFramework.Controls.MetroTile();
            this.Appoint_tile = new MetroFramework.Controls.MetroTile();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.metroTile10 = new MetroFramework.Controls.MetroTile();
            this.MSM1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.todo_tile = new MetroFramework.Controls.MetroTile();
            this.MenuLabel = new System.Windows.Forms.Label();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.MSM1)).BeginInit();
            this.SuspendLayout();
            // 
            // uni_tile
            // 
            this.uni_tile.ActiveControl = null;
            this.uni_tile.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.uni_tile, "uni_tile");
            this.uni_tile.Name = "uni_tile";
            this.uni_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("uni_tile.TileImage")));
            this.uni_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uni_tile.UseCustomForeColor = true;
            this.uni_tile.UseSelectable = true;
            this.uni_tile.UseTileImage = true;
            this.uni_tile.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Selfstd_tile
            // 
            this.Selfstd_tile.ActiveControl = null;
            resources.ApplyResources(this.Selfstd_tile, "Selfstd_tile");
            this.Selfstd_tile.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Selfstd_tile.ForeColor = System.Drawing.Color.White;
            this.Selfstd_tile.Name = "Selfstd_tile";
            this.Selfstd_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("Selfstd_tile.TileImage")));
            this.Selfstd_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Selfstd_tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.Selfstd_tile.UseCustomForeColor = true;
            this.Selfstd_tile.UseSelectable = true;
            this.Selfstd_tile.UseStyleColors = true;
            this.Selfstd_tile.UseTileImage = true;
            this.Selfstd_tile.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.metroTile3, "metroTile3");
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile3.TileImage")));
            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // toread_tile
            // 
            this.toread_tile.ActiveControl = null;
            this.toread_tile.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.toread_tile, "toread_tile");
            this.toread_tile.Name = "toread_tile";
            this.toread_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("toread_tile.TileImage")));
            this.toread_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toread_tile.UseCustomForeColor = true;
            this.toread_tile.UseSelectable = true;
            this.toread_tile.UseTileImage = true;
            this.toread_tile.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.metroTile5, "metroTile5");
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile5.TileImage")));
            this.metroTile5.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile5.UseCustomForeColor = true;
            this.metroTile5.UseSelectable = true;
            this.metroTile5.UseStyleColors = true;
            this.metroTile5.UseTileImage = true;
            // 
            // towatch_tile
            // 
            this.towatch_tile.ActiveControl = null;
            this.towatch_tile.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.towatch_tile, "towatch_tile");
            this.towatch_tile.Name = "towatch_tile";
            this.towatch_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("towatch_tile.TileImage")));
            this.towatch_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.towatch_tile.UseCustomForeColor = true;
            this.towatch_tile.UseSelectable = true;
            this.towatch_tile.UseTileImage = true;
            this.towatch_tile.Click += new System.EventHandler(this.metroTile7_Click);
            // 
            // Appoint_tile
            // 
            this.Appoint_tile.ActiveControl = null;
            this.Appoint_tile.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.Appoint_tile, "Appoint_tile");
            this.Appoint_tile.Name = "Appoint_tile";
            this.Appoint_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("Appoint_tile.TileImage")));
            this.Appoint_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Appoint_tile.UseCustomForeColor = true;
            this.Appoint_tile.UseSelectable = true;
            this.Appoint_tile.UseTileImage = true;
            this.Appoint_tile.Click += new System.EventHandler(this.metroTile8_Click);
            // 
            // metroTile9
            // 
            this.metroTile9.ActiveControl = null;
            this.metroTile9.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.metroTile9, "metroTile9");
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile9.TileImage")));
            this.metroTile9.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile9.UseCustomForeColor = true;
            this.metroTile9.UseSelectable = true;
            this.metroTile9.UseTileImage = true;
            this.metroTile9.Click += new System.EventHandler(this.metroTile9_Click);
            // 
            // metroTile10
            // 
            this.metroTile10.ActiveControl = null;
            this.metroTile10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.metroTile10.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.metroTile10, "metroTile10");
            this.metroTile10.Name = "metroTile10";
            this.metroTile10.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile10.TileImage")));
            this.metroTile10.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile10.UseCustomForeColor = true;
            this.metroTile10.UseSelectable = true;
            this.metroTile10.UseStyleColors = true;
            this.metroTile10.UseTileImage = true;
            this.metroTile10.Click += new System.EventHandler(this.metroTile10_Click);
            // 
            // MSM1
            // 
            this.MSM1.Owner = this;
            this.MSM1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Name = "label1";
            // 
            // todo_tile
            // 
            this.todo_tile.ActiveControl = null;
            this.todo_tile.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.todo_tile, "todo_tile");
            this.todo_tile.Name = "todo_tile";
            this.todo_tile.TileImage = ((System.Drawing.Image)(resources.GetObject("todo_tile.TileImage")));
            this.todo_tile.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.todo_tile.UseCustomForeColor = true;
            this.todo_tile.UseSelectable = true;
            this.todo_tile.UseTileImage = true;
            this.todo_tile.Click += new System.EventHandler(this.metroTile6_Click);
            // 
            // MenuLabel
            // 
            resources.ApplyResources(this.MenuLabel, "MenuLabel");
            this.MenuLabel.BackColor = System.Drawing.Color.Transparent;
            this.MenuLabel.ForeColor = System.Drawing.Color.White;
            this.MenuLabel.Name = "MenuLabel";
            // 
            // DetailsLabel
            // 
            resources.ApplyResources(this.DetailsLabel, "DetailsLabel");
            this.DetailsLabel.BackColor = System.Drawing.Color.Transparent;
            this.DetailsLabel.ForeColor = System.Drawing.Color.White;
            this.DetailsLabel.Name = "DetailsLabel";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            resources.ApplyResources(this.metroTile1, "metroTile1");
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click_1);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            resources.ApplyResources(this.metroTile2, "metroTile2");
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile2.TileImage")));
            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click_1);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = ((System.Drawing.Image)(resources.GetObject("$this.BackImage")));
            this.BackMaxSize = 1135;
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.MenuLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Selfstd_tile);
            this.Controls.Add(this.toread_tile);
            this.Controls.Add(this.metroTile5);
            this.Controls.Add(this.todo_tile);
            this.Controls.Add(this.towatch_tile);
            this.Controls.Add(this.Appoint_tile);
            this.Controls.Add(this.metroTile9);
            this.Controls.Add(this.metroTile10);
            this.Controls.Add(this.uni_tile);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile3);
            this.Name = "MainForm";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.CornflowerBlue;
            this.Load += new System.EventHandler(this.MainForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.MSM1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile uni_tile;
        private MetroFramework.Controls.MetroTile Selfstd_tile;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile toread_tile;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile towatch_tile;
        private MetroFramework.Controls.MetroTile Appoint_tile;
        private MetroFramework.Controls.MetroTile metroTile9;
        private MetroFramework.Controls.MetroTile metroTile10;
        private MetroFramework.Components.MetroStyleManager MSM1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile todo_tile;
        private System.Windows.Forms.Label MenuLabel;
        private System.Windows.Forms.Label DetailsLabel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
    }
}