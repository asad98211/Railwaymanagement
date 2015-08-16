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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Train_CheckedChanged(object sender, EventArgs e)
        {
            if (Train.Checked)
            {
                Employee.Checked = false;
                Stops.Checked = false;
                Station.Checked = false;
                Works.Checked = false;
                Fare.Checked = false;
            }
        }

        private void Station_CheckedChanged(object sender, EventArgs e)
        {
            if (Station.Checked)
            {
                Employee.Checked = false;
                Stops.Checked = false;
                Train.Checked = false;
                Works.Checked = false;
                Fare.Checked = false;
            }
        }

        private void Employee_CheckedChanged(object sender, EventArgs e)
        {
            if (Employee.Checked)
            {
                Train.Checked = false;
                Stops.Checked = false;
                Station.Checked = false;
                Works.Checked = false;
                Fare.Checked = false;
            }
        }

        private void Stops_CheckedChanged(object sender, EventArgs e)
        {
            if (Stops.Checked)
            {
                Employee.Checked = false;
                Train.Checked = false;
                Station.Checked = false;
                Works.Checked = false;
                Fare.Checked = false;
            }
        }

        private void Works_CheckedChanged(object sender, EventArgs e)
        {
            if (Works.Checked)
            {
                Employee.Checked = false;
                Stops.Checked = false;
                Station.Checked = false;
                Train.Checked = false;
                Fare.Checked = false;
            }
        }

        private void Fare_CheckedChanged(object sender, EventArgs e)
        {
            if (Fare.Checked)
            {
                Employee.Checked = false;
                Stops.Checked = false;
                Station.Checked = false;
                Works.Checked = false;
                Train.Checked = false;
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (Train.Checked)
            {

            }
            else if (Station.Checked)
            {

            }
            else if (Employee.Checked)
            {

            }
            else if (Works.Checked)
            {

            }
            else if (Stops.Checked)
            {

            }
            else if (Fare.Checked)
            {

            }
        }
    }
}
