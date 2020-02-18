namespace sportandAthlete
{
    partial class sportandTeamForm
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
            this.frmsport = new System.Windows.Forms.MenuStrip();
            this.mniCity = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLiverpool = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMadrid = new System.Windows.Forms.ToolStripMenuItem();
            this.mniParis = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.frmsport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmsport
            // 
            this.frmsport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCity});
            this.frmsport.Location = new System.Drawing.Point(0, 0);
            this.frmsport.Name = "frmsport";
            this.frmsport.Size = new System.Drawing.Size(800, 24);
            this.frmsport.TabIndex = 0;
            this.frmsport.Text = "Sport ";
            // 
            // mniCity
            // 
            this.mniCity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniLiverpool,
            this.mniMadrid,
            this.mniParis});
            this.mniCity.Name = "mniCity";
            this.mniCity.Size = new System.Drawing.Size(40, 20);
            this.mniCity.Text = "City";
            this.mniCity.Click += new System.EventHandler(this.SportToolStripMenuItem_Click);
            // 
            // mniLiverpool
            // 
            this.mniLiverpool.Name = "mniLiverpool";
            this.mniLiverpool.Size = new System.Drawing.Size(180, 22);
            this.mniLiverpool.Text = "Liverpool";
            this.mniLiverpool.Click += new System.EventHandler(this.LiverpoolToolStripMenuItem_Click);
            // 
            // mniMadrid
            // 
            this.mniMadrid.Name = "mniMadrid";
            this.mniMadrid.Size = new System.Drawing.Size(180, 22);
            this.mniMadrid.Text = "Madrid ";
            this.mniMadrid.Click += new System.EventHandler(this.RealMadridToolStripMenuItem_Click);
            // 
            // mniParis
            // 
            this.mniParis.Name = "mniParis";
            this.mniParis.Size = new System.Drawing.Size(180, 22);
            this.mniParis.Text = "Paris";
            this.mniParis.Click += new System.EventHandler(this.PSGFcToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTeam);
            this.groupBox1.Controls.Add(this.lblPlayer);
            this.groupBox1.Location = new System.Drawing.Point(108, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeam.Location = new System.Drawing.Point(38, 46);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(155, 37);
            this.lblTeam.TabIndex = 1;
            this.lblTeam.Text = "Liverpool ";
            this.lblTeam.Click += new System.EventHandler(this.LblTeam_Click);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(48, 134);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(106, 37);
            this.lblPlayer.TabIndex = 0;
            this.lblPlayer.Text = "Player";
            // 
            // sportandTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.frmsport);
            this.MainMenuStrip = this.frmsport;
            this.Name = "sportandTeamForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SportandAthleteForm_Load);
            this.frmsport.ResumeLayout(false);
            this.frmsport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip frmsport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.ToolStripMenuItem mniCity;
        private System.Windows.Forms.ToolStripMenuItem mniLiverpool;
        private System.Windows.Forms.ToolStripMenuItem mniMadrid;
        private System.Windows.Forms.ToolStripMenuItem mniParis;
    }
}

