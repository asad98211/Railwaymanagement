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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
            Clock.Start();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                Operation.Text = "Check";
            }
            else
            {
                Operation.Text = "Operation";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                Operation.Text = "Book";
            }
            else
            {
                Operation.Text = "Operation";
            }
        }

        private void Logoff_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                try
                {
                    SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                    string quarry = "select capacity from train where train_name='"+Train_Name.Text+"'";
                    SqlCommand instrain = new SqlCommand(quarry, ins);
                    SqlDataReader db;
                    ins.Open();
                    int cap=0,flag=0;
                    db=instrain.ExecuteReader();
                    while (db.Read())
                    {
                        cap = db.GetInt32(0);
                        flag++;
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("'"+Train_Name.Text+"' Doesnt Exist in Database");
                    }
                    else
                    {
                        MessageBox.Show("'" + Train_Name.Text + "' Has '" + cap.ToString() + "' Seats");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(checkBox2.Checked)
            {
                try
                {
                    SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                    string quarry = "select train_id from train where train_name='" + Train_Name.Text + "'";
                    SqlCommand instrain = new SqlCommand(quarry, ins);
                    SqlDataReader db;
                    ins.Open();
                    int flag = 0;
                    int tid = 0;
                    db = instrain.ExecuteReader();
                    while (db.Read())
                    {
                        tid = db.GetInt32(0);
                        flag++;
                    }
                    if (flag == 0)
                    {
                        MessageBox.Show("'" + Train_Name.Text + "' Doesnt Exist in Database");
                    }
                    else
                    {
                        Book_Ticket bkt = new Book_Ticket(tid,Convert.ToDateTime(JourneyDay));
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            clockTck.Text = dt.ToString();
        }

        private void JourneyDay_ValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
