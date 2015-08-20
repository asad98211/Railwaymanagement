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
            
            if (Train.Checked)
            {
                this.Hide();
                insert_train it = new insert_train();
                it.ShowDialog();
                this.Show();
            }
            else if (Station.Checked)
            {
                this.Hide();
                ins_station st = new ins_station();
                st.ShowDialog();
                this.Show();
            }
            else if (Employee.Checked)
            {
                this.Hide();
                Ins_employee st = new Ins_employee();
                st.ShowDialog();
                this.Show();
            }
            else if (Works.Checked)
            {
                this.Hide();
                Ins_works nwork = new Ins_works();
                nwork.ShowDialog();
                this.Show();
            }
            else if (Stops.Checked)
            {
                this.Hide();
                Ins_stops instop = new Ins_stops();
                instop.ShowDialog();
                this.Show();
            }
            else if (Fare.Checked)
            {
                this.Hide();
                ins_fare in_fr = new ins_fare();
                in_fr.ShowDialog();
                this.Show();
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (Train.Checked)
            {
                this.Hide();
                update_train it = new update_train();
                it.ShowDialog();
                this.Show();
            }
            else if (Station.Checked)
            {
                this.Hide();
                Update_station st = new Update_station();
                st.ShowDialog();
                this.Show();
            }
            else if (Employee.Checked)
            {
                this.Hide();
                update_employee st = new update_employee();
                st.ShowDialog();
                this.Show();
            }
            else if (Works.Checked)
            {
                this.Hide();
               Update_works nwork = new Update_works();
                nwork.ShowDialog();
                this.Show();
            }
            else if (Stops.Checked)
            {
                this.Hide();
                update_stops instop = new update_stops();
                instop.ShowDialog();
                this.Show();
            }
            else if (Fare.Checked)
            {
                this.Hide();
                Update_fare in_fr = new Update_fare();
                in_fr.ShowDialog();
                this.Show();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (Train.Checked)
            {
                this.Hide();
                delete_train it = new delete_train();
                it.ShowDialog();
                this.Show();
            }
            else if (Station.Checked)
            {
                this.Hide();
                Delstation st = new Delstation();
                st.ShowDialog();
                this.Show();
            }
            else if (Employee.Checked)
            {
                this.Hide();
                Delete_Employee st = new Delete_Employee();
                st.ShowDialog();
                this.Show();
            }
            else if (Works.Checked)
            {
                this.Hide();
                Update_works nwork = new Update_works();
                nwork.ShowDialog();
                this.Show();
            }
            else if (Stops.Checked)
            {
                this.Hide();
                update_stops instop = new update_stops();
                instop.ShowDialog();
                this.Show();
            }
            else if (Fare.Checked)
            {
                this.Hide();
                Update_fare in_fr = new Update_fare();
                in_fr.ShowDialog();
                this.Show();
            }
        }
    }
}
