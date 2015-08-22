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
    public partial class Ins_employee : Form
    {
        public Ins_employee()
        {
            InitializeComponent();
            if (!checkBox1.Checked)
            {
                password.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "execute ins_employee '"+Convert.ToInt32(Emp_Id.Text)+"','"+Empname.Text+"','"+username.Text+"','"+password.Text+"','"+DOB.Text+"','"+Convert.ToInt32(salary.Text)+"','"+Designation.Text+"'";
                SqlCommand instrain = new SqlCommand(quarry, ins);
                ins.Open();
                instrain.ExecuteNonQuery();
                MessageBox.Show("Employee info is added");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                password.PasswordChar = '*';
            }
            else
            {
                password.PasswordChar = '\0';
            }
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Designation_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ins_employee_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
