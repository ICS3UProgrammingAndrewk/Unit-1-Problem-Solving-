/*
 * Created by: Andrew Kuekam
 * Created on: 2020-04-01
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pizza Cost
 * This program...
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

namespace PizzaCostAndrew
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare local variables
            double Diameter, costAfterTax;

            //convert the diameter to a double
            Diameter = double.Parse(txtDiameter.Text);

            //calculate the cost before and after tax
            costAfterTax = 0.50 * Diameter + 0.99 + 0.75;

            //display the cost in the label, rounded to 2 decimal places
            lblcostAfterTax.Text = String.Format("$(8:76)", costAfterTax);

            //show Cost Answer
            this.lblcostAfterTax.Show();
            this.lblcost.Show();

        }

        private void frmPizzaCost_Load(object sender, EventArgs e)
        {
            //hide Cost Answer
            this.lblcostAfterTax.Hide();
            this.lblcost.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this close the program
            this.Close();
        }
    }
}
