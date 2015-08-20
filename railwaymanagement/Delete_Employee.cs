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
    public partial class Delete_Employee : Form
    {
        public Delete_Employee()
        {
            InitializeComponent();
        }
        
        private void Delete_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                    string quarry = "delete from employee where emp_id='" + Data.Text + "'";
                    string quarry1 = "delete from works where emp_i='"+Data.Text+"'";
                    SqlCommand deltrain = new SqlCommand(quarry, ins);
                    SqlCommand delworks = new SqlCommand(quarry1, ins);
                    ins.Open();
                    deltrain.ExecuteNonQuery();
                    delworks.ExecuteNonQuery();
                    MessageBox.Show("The entry Employee Id = '" + Data.Text + "' is deleted.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (checkBox2.Checked)
            {
                try
                {
                    SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                    string quarry = "delete from employee where emp_name='" + Data.Text + "'";
                    string quarry1 = "delete from works emp_id=(select emp_id from employee)";
                    SqlCommand deltrain = new SqlCommand(quarry, ins);
                    SqlCommand delworks = new SqlCommand(quarry, ins);
                    ins.Open();
                    delworks.ExecuteNonQuery();
                    deltrain.ExecuteNonQuery();
                    MessageBox.Show("The entry Employees Name = '" + Data.Text + "' is deleted.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }
    }
}
