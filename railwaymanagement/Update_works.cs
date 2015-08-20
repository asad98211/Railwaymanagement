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
    public partial class Update_works : Form
    {
        public Update_works()
        {
            InitializeComponent();
            fillcombo();
        }
        private void fillcombo()
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from works";
                SqlCommand station = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = station.ExecuteReader();
                while (reader.Read())
                {
                    Emp_id.Items.Add(reader.GetInt32(0).ToString());
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
                string quarry = "execute update_works '" + Convert.ToInt32(Emp_id.Text) + "','" + Convert.ToInt32(St_id.Text) + "','" + Jdate.Text + "','" + Start_time.Text + "','" + End_time.Text + "'";
                SqlCommand upworks = new SqlCommand(quarry, ins);
                ins.Open();
                upworks.ExecuteNonQuery();
                MessageBox.Show("Works info is Updated");
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

        private void Emp_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from works where emp_id = '" + Emp_id.Text + "'";
                SqlCommand station = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = station.ExecuteReader();
                while (reader.Read())
                {
                    Emp_id.Text = reader.GetInt32(0).ToString();
                    St_id.Text = reader.GetInt32(1).ToString();
                    Jdate.Text = reader.GetDateTime(2).ToString("MM/dd/yyyy");
                    Start_time.Text = reader.GetTimeSpan(3).ToString();
                    End_time.Text = reader.GetTimeSpan(4).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Update_works_Load(object sender, EventArgs e)
        {

        }
    }
}
