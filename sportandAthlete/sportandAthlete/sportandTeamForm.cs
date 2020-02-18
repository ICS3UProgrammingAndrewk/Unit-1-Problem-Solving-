/*
 * Created by: Andrew Kuekam
 * Created on: 2020-02-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #7 - Name of Program
 * This program when you click on the menu item, the sport and Team changes accordingly.
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

namespace sportandAthlete
{
    public partial class sportandTeamForm : Form
    {
        public sportandTeamForm()
        {
            InitializeComponent();
        }

        private void SportandAthleteForm_Load(object sender, EventArgs e)
        {

        }

        private void LiverpoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the labels to reflect City
            this.lblTeam.Text = "Liverpool FC";
            this.lblPlayer.Text = "Mane";
        }

        private void SportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RealMadridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the labels to reflect City
            this.lblTeam.Text = "Real Madrid FC";
            this.lblPlayer.Text = "Rodrigo";

        }

        private void PSGFcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the labels to reflect City
            this.lblTeam.Text = "PSG FC";
            this.lblPlayer.Text = "Neymar";

        }

        private void LblTeam_Click(object sender, EventArgs e)
        {

        }
    }
}
