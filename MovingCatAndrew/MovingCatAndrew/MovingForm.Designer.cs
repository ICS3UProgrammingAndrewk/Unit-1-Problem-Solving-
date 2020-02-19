namespace MovingCatAndrew
{
    partial class frmMovingCat
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
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.neymarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neymar1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neymar2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picNeymar = new System.Windows.Forms.PictureBox();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.mnuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNeymar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mniCat,
            this.neymarToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(800, 24);
            this.mnuFile.TabIndex = 0;
            this.mnuFile.Text = "File";
            this.mnuFile.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniCat
            // 
            this.mniCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mniCat.Name = "mniCat";
            this.mniCat.Size = new System.Drawing.Size(37, 20);
            this.mniCat.Text = "Cat";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(98, 22);
            this.mniCat1.Text = "Cat1";
            this.mniCat1.Click += new System.EventHandler(this.MniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(98, 22);
            this.mniCat2.Text = "Cat2";
            this.mniCat2.Click += new System.EventHandler(this.MniCat2_Click);
            // 
            // neymarToolStripMenuItem
            // 
            this.neymarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neymar1ToolStripMenuItem,
            this.neymar2ToolStripMenuItem});
            this.neymarToolStripMenuItem.Name = "neymarToolStripMenuItem";
            this.neymarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.neymarToolStripMenuItem.Text = "Neymar";
            // 
            // neymar1ToolStripMenuItem
            // 
            this.neymar1ToolStripMenuItem.Name = "neymar1ToolStripMenuItem";
            this.neymar1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neymar1ToolStripMenuItem.Text = "Neymar1";
            this.neymar1ToolStripMenuItem.Click += new System.EventHandler(this.Neymar1ToolStripMenuItem_Click);
            // 
            // neymar2ToolStripMenuItem
            // 
            this.neymar2ToolStripMenuItem.Name = "neymar2ToolStripMenuItem";
            this.neymar2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neymar2ToolStripMenuItem.Text = "Neymar2";
            this.neymar2ToolStripMenuItem.Click += new System.EventHandler(this.Neymar2ToolStripMenuItem_Click);
            // 
            // picNeymar
            // 
            this.picNeymar.Image = global::MovingCatAndrew.Properties.Resources.neymar1;
            this.picNeymar.Location = new System.Drawing.Point(333, 98);
            this.picNeymar.Name = "picNeymar";
            this.picNeymar.Size = new System.Drawing.Size(398, 277);
            this.picNeymar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNeymar.TabIndex = 2;
            this.picNeymar.TabStop = false;
            // 
            // picCat
            // 
            this.picCat.Image = global::MovingCatAndrew.Properties.Resources.cat1;
            this.picCat.Location = new System.Drawing.Point(70, 146);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(167, 164);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat.TabIndex = 1;
            this.picCat.TabStop = false;
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picNeymar);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNeymar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniCat;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.PictureBox picNeymar;
        private System.Windows.Forms.ToolStripMenuItem neymarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neymar1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neymar2ToolStripMenuItem;
    }
}

