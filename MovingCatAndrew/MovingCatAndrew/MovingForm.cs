/*
 * Created by: Andrew Kuekam
 * Created on: 2020-02-29
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Moving cat
 * This program  displays a menu strip with a drop-down menu of 2 menu items. When I click 
 * on each menu item, the picture in the picture box changes
 * accordingly.  When I click on the Exit menu item, the program closes.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingCatAndrew
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MniCat2_Click(object sender, EventArgs e)
        {
            //this change the picture to cat 2
            this.picCat.Image = Properties.Resources.cat2;
        }

        private void MniCat1_Click(object sender, EventArgs e)
        {
            // this change the picture to cat 1
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this close the program
            this.Close();
        }

        private void Neymar2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this change the picture to Neymar 2
            this.picNeymar.Image = Properties.Resources.neymar2;
        }

        private void Neymar1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this change the picture to Neymar 1
            this.picNeymar.Image = Properties.Resources.neymar1;
        }
    }
}
