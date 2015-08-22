using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace railwaymanagement
{
    public partial class Station_Master_Panel : Form
    {
        
        public Station_Master_Panel()
        {
            
            InitializeComponent();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Train_CheckedChanged(object sender, EventArgs e)
        {
            if (Train.Checked)
            {
                Stops.Checked = false;
                Employee.Checked = false;
                Oparation.Text = "Select";
                label1.Text = "Cancel A Train.";
            }
            else
            {
                label1.Text = "Description.";
            }
        }

        private void Employee_CheckedChanged(object sender, EventArgs e)
        {
            if (Employee.Checked)
            {
                Stops.Checked = false;
                Train.Checked = false;
                Oparation.Text = "Select";
                label1.Text = "Suspend An Employee.";
            }
        }

        private void Stops_CheckedChanged(object sender, EventArgs e)
        {
            if (Stops.Checked)
            {
                Employee.Checked = false;
                Train.Checked = false;
                Oparation.Text = "Select";
                label1.Text = "Prospond A Train.";
            }
        }

        private void Oparation_Click(object sender, EventArgs e)
        {
            if (Train.Checked)
            {
                MessageBox.Show("This option is under maintanance please try later.");
            }
           else if (Train.Checked)
            {
                MessageBox.Show("This option is under maintanance please try later.");
            }
           else if (Stops.Checked)
            {
                MessageBox.Show("This option is under maintanance please try later.");
            }
            else
            {
                MessageBox.Show("Select Any Of the Choices first.");
            }
        }
    }
}
