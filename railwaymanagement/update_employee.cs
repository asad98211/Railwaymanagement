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
    public partial class update_employee : Form
    {
        public update_employee()
        {
            InitializeComponent();
            fillcombo();
            if (!checkBox1.Checked)
            {
                password.PasswordChar = '*';
            }
        }
        private void fillcombo()
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from employee";
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
                string quarry = "execute up_emp '" + Convert.ToInt32(Emp_id.Text) + "','" + Empname.Text + "','"+username.Text+"','"+password.Text+"','"+DOB.Text+"','" + Convert.ToInt32(salary.Text) + "','" + Designation.Text + "'";
                SqlCommand upemployee = new SqlCommand(quarry, ins);
                ins.Open();
                upemployee.ExecuteNonQuery();
                MessageBox.Show("Employee info is Updated");
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

        private void Emp_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "select * from employee where emp_id = '" + Emp_id.Text + "'";
                SqlCommand station = new SqlCommand(quarry, ins);
                SqlDataReader reader;
                ins.Open();
                reader = station.ExecuteReader();
                while (reader.Read())
                {
                    Emp_id.Text = reader.GetInt32(0).ToString();
                    Empname.Text = reader.GetString(1);
                    username.Text = reader.GetString(2);
                    password.Text = reader.GetString(3);
                    DOB.Text = reader.GetDateTime(4).ToString("MM/dd/yyyy");
                    salary.Text = reader.GetInt32(5).ToString();
                    Designation.Text = reader.GetString(6);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
