
namespace Test
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.ground = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            this.bottompipe = new System.Windows.Forms.PictureBox();
            this.toppipe = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.ghost = new System.Windows.Forms.PictureBox();
            this.gameover = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.Button();
            this.quit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottompipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toppipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ground, "ground");
            this.ground.Name = "ground";
            this.ground.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bird, "bird");
            this.bird.Name = "bird";
            this.bird.TabStop = false;
            // 
            // bottompipe
            // 
            this.bottompipe.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bottompipe, "bottompipe");
            this.bottompipe.Name = "bottompipe";
            this.bottompipe.TabStop = false;
            // 
            // toppipe
            // 
            this.toppipe.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.toppipe, "toppipe");
            this.toppipe.Name = "toppipe";
            this.toppipe.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timerevent);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(179)))), ((int)(((byte)(236)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // ghost
            // 
            this.ghost.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.ghost, "ghost");
            this.ghost.Name = "ghost";
            this.ghost.TabStop = false;
            // 
            // gameover
            // 
            this.gameover.BackColor = System.Drawing.Color.Transparent;
            this.gameover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.gameover, "gameover");
            this.gameover.Name = "gameover";
            this.gameover.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gameover);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Controls.Add(this.quit);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.menu, "menu");
            this.menu.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.menu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.menu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.menu.ForeColor = System.Drawing.Color.Transparent;
            this.menu.Name = "menu";
            this.menu.UseVisualStyleBackColor = false;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // quit
            // 
            this.quit.BackColor = System.Drawing.Color.Transparent;
            this.quit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.quit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.quit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.quit, "quit");
            this.quit.ForeColor = System.Drawing.Color.Transparent;
            this.quit.Name = "quit";
            this.quit.UseVisualStyleBackColor = false;
            this.quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // game
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.toppipe);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.bottompipe);
            this.Controls.Add(this.ghost);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "game";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Upkey);
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottompipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toppipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox bottompipe;
        private System.Windows.Forms.PictureBox toppipe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ghost;
        private System.Windows.Forms.PictureBox gameover;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Panel panel2;
    }
}