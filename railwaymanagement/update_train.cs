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
    public partial class update_train : Form
    {
        public update_train()
        {
            InitializeComponent();
            fillcombo();
        }
        private void fillcombo()
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from train";
                SqlCommand train = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = train.ExecuteReader();
                while (reader.Read())
                {
                    Train_id.Items.Add(reader.GetInt32(0).ToString());
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
                string quarry = "execute up_train '" +Convert.ToInt32(Train_id.Text) + "','" + Tname.Text + "','" + offday.Text + "','" +Convert.ToInt32( No_pass.Text) + "','" +Convert.ToInt32(capacity.Text) +"'";
                SqlCommand uptrain = new SqlCommand(quarry, ins);
                ins.Open();
                uptrain.ExecuteNonQuery();
                MessageBox.Show("Train info is Updated");
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

        private void Train_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from train where train_id = '"+Train_id.Text+"'";
                SqlCommand uptrain = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader= uptrain.ExecuteReader();
                while (reader.Read())
                {
                    Train_id.Text = reader.GetInt32(0).ToString();
                    Tname.Text = reader.GetString(1);
                    offday.Text = reader.GetString(2);
                    No_pass.Text = reader.GetInt32(3).ToString();
                    capacity.Text = reader.GetInt32(4).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
