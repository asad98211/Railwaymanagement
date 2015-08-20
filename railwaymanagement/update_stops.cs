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
    public partial class update_stops : Form
    {
        public update_stops()
        {
            InitializeComponent();
            fillcombo();
        }
        private void fillcombo()
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from stops";
                SqlCommand station = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = station.ExecuteReader();
                while (reader.Read())
                {
                    st_id.Items.Add(reader.GetInt32(0).ToString());
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
                string quarry = "execute update_stops '" + Convert.ToInt32(st_id.Text) + "','" + Convert.ToInt32(Train_id.Text) + "','" + Arrival_time.Text + "','" + Departure_time.Text + "','" + Convert.ToInt32(Platform_no.Text) + "'";
                SqlCommand uptrain = new SqlCommand(quarry, ins);
                ins.Open();
                uptrain.ExecuteNonQuery();
                MessageBox.Show("Stops info is Updated.");
                this.DialogResult = DialogResult.OK;
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

        private void st_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from stops where station_id = '" + st_id.Text + "'";
                SqlCommand station = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = station.ExecuteReader();
                while (reader.Read())
                {
                    st_id.Text = reader.GetInt32(0).ToString();
                    Train_id.Text = reader.GetInt32(1).ToString();
                    Platform_no.Text = reader.GetInt32(4).ToString();
                    Arrival_time.Text = reader.GetTimeSpan(2).ToString();
                    Departure_time.Text = reader.GetTimeSpan(3).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
