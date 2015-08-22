using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace railwaymanagement
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        private void Train_CheckedChanged(object sender, EventArgs e)
        {
            if (Train.Checked && idk.Checked)
            {
                Fare.Checked = false;
                label1.Text = "Destination";
            }
           else if (Train.Checked)
            {
                Fare.Checked = false;
                label1.Text = "Train Name";
            }
            else
            {
                label1.Text = "Select";
            }

        }

        private void Fare_CheckedChanged(object sender, EventArgs e)
        {
            if (Fare.Checked && idk.Checked)
            {
                Train.Checked = false;
                label1.Text = "Destination";
            }
            else if (Fare.Checked)
            {
                
                Train.Checked = false;
                label1.Text = "Train Name";
            }
            else
            {
                label1.Text = "Select";
            }

        }

        private void idk_CheckedChanged(object sender, EventArgs e)
        {
            if (Fare.Checked && idk.Checked|| Train.Checked && idk.Checked)
            {
                label1.Text = "Destination";
            }
            else if (Fare.Checked||Train.Checked)
            {

                label1.Text = "Train Name";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (idk.Checked && Train.Checked)
            {
                try
                {
                    SqlConnection sq = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                    string quarry = "select station.station_name,train.train_name,stops.arrival_time,stops.departure_time,stops.platform_no from train join stops on train.train_id=stops.train_id join station on station.station_id=stops.station_id where station.station_name='"+data.Text+"'";
                    SqlCommand sqcmd = new SqlCommand(quarry,sq);
                    SqlDataAdapter adt = new SqlDataAdapter();
                    adt.SelectCommand = sqcmd;
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    demo dm = new demo(dt);
                    this.Hide();
                    dm.ShowDialog();
                    this.Show();
                    adt.Update(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (idk.Checked && Fare.Checked)
            {
                try
                {
                    SqlConnection sq = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                    string quarry = "select 'Dhaka' as From_,station.station_name as To_,train.train_name,fare.cost,stops.arrival_time,stops.departure_time from train join stops on train.train_id=stops.train_id join station on station.station_id=stops.station_id join fare on train.train_id=fare.train_id where station.station_name ='" + data.Text + "'";
                    SqlCommand sqcmd = new SqlCommand(quarry, sq);
                    SqlDataAdapter adt = new SqlDataAdapter();
                    adt.SelectCommand = sqcmd;
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    demo dm = new demo(dt);
                    this.Hide();
                    dm.ShowDialog();
                    this.Show();
                    adt.Update(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (Train.Checked)
            {
                try
                {
                    SqlConnection sq = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                    string quarry = "select station.station_name,train.train_name,stops.arrival_time,stops.departure_time,stops.platform_no from train join stops on train.train_id=stops.train_id join station on station.station_id=stops.station_id where train.train_name='" + data.Text + "'";
                    SqlCommand sqcmd = new SqlCommand(quarry, sq);
                    SqlDataAdapter adt = new SqlDataAdapter();
                    adt.SelectCommand = sqcmd;
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    demo dm = new demo(dt);
                    this.Hide();
                    dm.ShowDialog();
                    this.Show();
                    adt.Update(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (Fare.Checked)
            {
                try
                {
                    SqlConnection sq = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                    string quarry = "select 'Dhaka' as From_,station.station_name as To_,train.train_name,fare.cost,stops.arrival_time,stops.departure_time from train join stops on train.train_id=stops.train_id join station on station.station_id=stops.station_id join fare on train.train_id=fare.train_id where train.train_name ='" + data.Text + "'";
                    SqlCommand sqcmd = new SqlCommand(quarry, sq);
                    SqlDataAdapter adt = new SqlDataAdapter();
                    adt.SelectCommand = sqcmd;
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    demo dm = new demo(dt);
                    this.Hide();
                    dm.ShowDialog();
                    this.Show();
                    adt.Update(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }
    }
}
