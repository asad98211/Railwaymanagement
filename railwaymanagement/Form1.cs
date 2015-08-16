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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            password.MaxLength = 20;
            User_name.MaxLength = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection login = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
            SqlCommand selectcmd = new SqlCommand("select * from employee where user_name='" + User_name.Text + "' And pass='" + password.Text + "'", login);
            SqlDataReader mdreader;
            login.Open();
            mdreader = selectcmd.ExecuteReader();
            DataTable dt = new DataTable();
            string master=""; 
            int flag = 0;
            while (mdreader.Read())
            {
               master= mdreader.GetString(7);
                flag++;
            }
            if (User_name.Text.Equals("Admin") && password.Text.Equals("shadowmaster"))
            {
                MessageBox.Show("welcome admin");
                this.Hide();
                Admin ad = new Admin();
                ad.ShowDialog();
            }
            else if (flag==1)
            {
                if (master == "Yes")
                {

                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Sry User_name or Password is incorrect.");
            }
  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void information_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
