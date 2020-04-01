namespace PizzaCostAndrew
{
    partial class frmPizzaCost
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
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblcost = new System.Windows.Forms.Label();
            this.BtnCalculator = new System.Windows.Forms.Button();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.lblcostAfterTax = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(33, 136);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(405, 24);
            this.lblDiameter.TabIndex = 0;
            this.lblDiameter.Text = "Enter the diameter of the pizza (in inches):";
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcost.Location = new System.Drawing.Point(24, 306);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(260, 24);
            this.lblcost.TabIndex = 1;
            this.lblcost.Text = "The Cost (including tax) is:";
            // 
            // BtnCalculator
            // 
            this.BtnCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculator.Location = new System.Drawing.Point(116, 201);
            this.BtnCalculator.Name = "BtnCalculator";
            this.BtnCalculator.Size = new System.Drawing.Size(168, 50);
            this.BtnCalculator.TabIndex = 2;
            this.BtnCalculator.Text = "Calculate Cost";
            this.BtnCalculator.UseVisualStyleBackColor = false;
            this.BtnCalculator.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(454, 136);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(100, 20);
            this.txtDiameter.TabIndex = 3;
            this.txtDiameter.Text = "  ";
            // 
            // lblcostAfterTax
            // 
            this.lblcostAfterTax.AutoSize = true;
            this.lblcostAfterTax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcostAfterTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcostAfterTax.Location = new System.Drawing.Point(322, 306);
            this.lblcostAfterTax.Name = "lblcostAfterTax";
            this.lblcostAfterTax.Size = new System.Drawing.Size(43, 24);
            this.lblcostAfterTax.TabIndex = 4;
            this.lblcostAfterTax.Text = "???";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcostAfterTax);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.BtnCalculator);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.lblDiameter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost By Andrew K.";
            this.Load += new System.EventHandler(this.frmPizzaCost_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.Button BtnCalculator;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Label lblcostAfterTax;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
    }
}

