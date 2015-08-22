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
    public partial class deletestops : Form
    {
        public deletestops()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (idk.Checked)
            {
                try
                {
                    SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                    string quarry = "execute del_stopsn '"+st_id.Text+"','"+t_id+"'";
                    SqlCommand delemp = new SqlCommand(quarry, ins);
                    ins.Open();
                    delemp.ExecuteNonQuery();
                    MessageBox.Show("The entry Station Name = '" + st_id.Text + "' And Train_Name= '" + t_id.Text + "' is deleted.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                    string quarry = "delete from stops where station_id='" + st_id.Text + "'And train_id='" + t_id.Text + "'";
                    string quarry1 = "delete from fare where station_id='" + st_id.Text + "' And train_id='" + t_id.Text + "'";
                    SqlCommand delemp = new SqlCommand(quarry, ins);
                    SqlCommand delworks = new SqlCommand(quarry1, ins);
                    ins.Open();
                    delemp.ExecuteNonQuery();
                    delworks.ExecuteNonQuery();
                    MessageBox.Show("The entry Station Id = '" + st_id.Text + "' And Train_id= '" + t_id.Text + "' is deleted.");
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void idk_CheckedChanged(object sender, EventArgs e)
        {
            if (idk.Checked)
            {
                label1.Text = "Station_Name:";
                label2.Text = "Train_Name:";
            }
            else
            {
                label1.Text = "Station_Id:";
                label2.Text = "Train_Id:";

            }
        }
    }
}
