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
    public partial class Cancel_Train : Form
    {
        public Cancel_Train()
        {
            InitializeComponent();
        }
        private void fillcombo()
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select Train_name from train";
                SqlCommand station = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = station.ExecuteReader();
                while (reader.Read())
                {
                    Tname.Items.Add(reader.GetInt32(0).ToString());
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

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select Train_id from train where ";
                SqlCommand station = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = station.ExecuteReader();
                while (reader.Read())
                {
                    Tname.Items.Add(reader.GetInt32(0).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
