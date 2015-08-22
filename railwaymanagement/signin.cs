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
    public partial class Sign_in : Form
    {
        public Sign_in()
        {
            InitializeComponent();
            password.PasswordChar = '*';
            password.MaxLength = 20;
            User_name.MaxLength = 10;
            User_name.Text = "sam";
            password.Text = "bari";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection login = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
            SqlCommand selectcmd = new SqlCommand("select * from employee where user_name='" + User_name.Text + "' And pass='" + password.Text + "'", login);
            SqlDataReader mdreader;
            login.Open();
            mdreader = selectcmd.ExecuteReader();
            string master="";
            int id;
            int flag = 0;
            while (mdreader.Read())
            {
                master= mdreader.GetString(6);
                id = mdreader.GetInt32(0);
                flag++;
            }
            if (User_name.Text.Equals("Admin") && password.Text.Equals("shadowmaster"))
            {
                MessageBox.Show("welcome admin");
                this.Hide();
                Admin ad = new Admin();
                ad.ShowDialog();
                this.Show();
                User_name.Text = "";
                password.Text = "";
            }
            else if (flag==1)
            {
                if (master.Equals("Master"))
                {
                    this.Hide();
                    Station_Master_Panel nw = new Station_Master_Panel();
                    nw.ShowDialog();
                    this.Show();

                }
                else if(master.Equals("Manager"))
                {
                    this.Hide();
                    Manager mg = new Manager();
                    mg.ShowDialog();
                    this.Show();
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
            this.Hide();
            Information inf = new Information();
            inf.ShowDialog();
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
