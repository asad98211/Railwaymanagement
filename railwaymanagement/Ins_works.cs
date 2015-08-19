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
    public partial class Ins_works : Form
    {
        public Ins_works()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                string quarry = "execute ins_works '" + Convert.ToInt32(Emp_Id.Text) + "','" + Convert.ToInt32(St_id.Text) + "','" + Jdate.Text + "','" + Start_time.Text + "','" + End_time.Text + "'";
                SqlCommand instrain = new SqlCommand(quarry, ins);
                ins.Open();
                instrain.ExecuteNonQuery();
                MessageBox.Show("Works info is added");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
