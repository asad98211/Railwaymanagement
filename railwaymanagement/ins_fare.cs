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
    public partial class ins_fare : Form
    {
        public ins_fare()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "execute ins_fare '" + Convert.ToInt32(Station_Id.Text) + "','" + Convert.ToInt32(Train_id.Text) + "','" +Convert.ToInt32( prev_st_id.Text) + "','" +Convert.ToInt32( distance.Text) + "','" +Convert.ToInt32( cost.Text )+ "'";
                SqlCommand instrain = new SqlCommand(quarry, ins);
                ins.Open();
                instrain.ExecuteNonQuery();
                MessageBox.Show("Fare info is added");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
