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
    public partial class Update_fare : Form
    {
        public Update_fare()
        {
            InitializeComponent();
            fillcombo();
        }
        private void fillcombo()
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from fare";
                SqlCommand station = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = station.ExecuteReader();
                while (reader.Read())
                {
                    train_id.Items.Add(reader.GetInt32(1).ToString());
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
                string quarry = "execute update_fare '" + Convert.ToInt32(Station_Id.Text) + "','" + Convert.ToInt32(train_id.Text) + "','" + Convert.ToInt32(prev_st_id.Text) + "','" + Convert.ToInt32(distance.Text) + "','" + Convert.ToInt32(cost.Text) + "'";
                SqlCommand instrain = new SqlCommand(quarry, ins);
                ins.Open();
                instrain.ExecuteNonQuery();
                MessageBox.Show("Fare info is Updated");
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

        private void train_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from fare where train_id = '" + train_id.Text + "'";
                SqlCommand station = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = station.ExecuteReader();
                while (reader.Read())
                {
                    Station_Id.Text = reader.GetInt32(0).ToString();
                    train_id.Text = reader.GetInt32(1).ToString();
                    prev_st_id.Text = reader.GetInt32(2).ToString();
                    distance.Text = reader.GetInt32(3).ToString();
                    cost.Text = reader.GetInt32(4).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
