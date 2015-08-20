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
    public partial class Update_station : Form
    {
        public Update_station()
        {
            InitializeComponent();
            fillcombo();
        }
        private void fillcombo()
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from station";
                SqlCommand station = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = station.ExecuteReader();
                while (reader.Read())
                {
                    Station_id.Items.Add(reader.GetInt32(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "execute up_train '" + Convert.ToInt32(Station_id.Text) + "','" + STname.Text + "','" +Convert.ToInt32(No_plat.Text) + "','" + Convert.ToInt32(no_emp.Text) + "'";
                SqlCommand upstation = new SqlCommand(quarry, ins);
                ins.Open();
                upstation.ExecuteNonQuery();
                MessageBox.Show("Station info is Updated");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Station_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from station where station_id = '" + Station_id.Text + "'";
                SqlCommand station = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = station.ExecuteReader();
                while (reader.Read())
                {
                    Station_id.Text = reader.GetInt32(0).ToString();
                    STname.Text = reader.GetString(1);
                    No_plat.Text = reader.GetInt32(2).ToString();
                    no_emp.Text = reader.GetInt32(3).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
