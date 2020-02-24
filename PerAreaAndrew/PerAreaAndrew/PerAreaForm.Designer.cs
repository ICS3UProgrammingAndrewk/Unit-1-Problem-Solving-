namespace PerAreaAndrew
{
    partial class frmPerArea
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
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbllength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnCaculator = new System.Windows.Forms.Button();
            this.lblPer = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerAnswer = new System.Windows.Forms.Label();
            this.lblAreaAnswer = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.mnuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(800, 24);
            this.mnuFile.TabIndex = 0;
            this.mnuFile.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // lbllength
            // 
            this.lbllength.AutoSize = true;
            this.lbllength.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllength.Location = new System.Drawing.Point(126, 139);
            this.lbllength.Name = "lbllength";
            this.lbllength.Size = new System.Drawing.Size(118, 25);
            this.lbllength.TabIndex = 1;
            this.lbllength.Text = "Length(m)";
            this.lbllength.Click += new System.EventHandler(this.Lbllength_Click);
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(126, 253);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(106, 25);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Width(m)";
            // 
            // btnCaculator
            // 
            this.btnCaculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaculator.Location = new System.Drawing.Point(542, 178);
            this.btnCaculator.Name = "btnCaculator";
            this.btnCaculator.Size = new System.Drawing.Size(175, 45);
            this.btnCaculator.TabIndex = 3;
            this.btnCaculator.Text = "Calculate";
            this.btnCaculator.UseVisualStyleBackColor = true;
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.Location = new System.Drawing.Point(127, 317);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(170, 24);
            this.lblPer.TabIndex = 4;
            this.lblPer.Text = "The Perimeter is:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(127, 370);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(124, 24);
            this.lblArea.TabIndex = 5;
            this.lblArea.Text = "The Area is:";
            // 
            // lblPerAnswer
            // 
            this.lblPerAnswer.AutoSize = true;
            this.lblPerAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerAnswer.Location = new System.Drawing.Point(427, 317);
            this.lblPerAnswer.Name = "lblPerAnswer";
            this.lblPerAnswer.Size = new System.Drawing.Size(43, 24);
            this.lblPerAnswer.TabIndex = 6;
            this.lblPerAnswer.Text = "???";
            // 
            // lblAreaAnswer
            // 
            this.lblAreaAnswer.AutoSize = true;
            this.lblAreaAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAreaAnswer.Location = new System.Drawing.Point(430, 370);
            this.lblAreaAnswer.Name = "lblAreaAnswer";
            this.lblAreaAnswer.Size = new System.Drawing.Size(43, 24);
            this.lblAreaAnswer.TabIndex = 7;
            this.lblAreaAnswer.Text = "???";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(302, 143);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 8;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(302, 253);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 9;
            // 
            // frmPerArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblAreaAnswer);
            this.Controls.Add(this.lblPerAnswer);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPer);
            this.Controls.Add(this.btnCaculator);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lbllength);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmPerArea";
            this.Text = "Perimeter and Area of Rectangle by Andrew";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbllength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnCaculator;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerAnswer;
        private System.Windows.Forms.Label lblAreaAnswer;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
    }
}

