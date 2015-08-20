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
    public partial class delete_train : Form
    {
        public delete_train()
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
                    string quarry = "delete from train where train_id='"+Data.Text+"'";
                    SqlCommand deltrain = new SqlCommand(quarry, ins);
                    ins.Open();
                    deltrain.ExecuteNonQuery();
                    MessageBox.Show("The entry Train Id = '"+Data.Text+"' is deleted.");
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
                    string quarry = "delete from train where train_name='" + Data.Text + "'";
                    SqlCommand deltrain = new SqlCommand(quarry, ins);
                    ins.Open();
                    deltrain.ExecuteNonQuery();
                    MessageBox.Show("The entry Train Name = '" + Data.Text + "' is deleted.");
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
