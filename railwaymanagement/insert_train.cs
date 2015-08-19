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
    public partial class insert_train : Form
    {
        public insert_train()
        {
            InitializeComponent();
            Tname.MaxLength = 30;
            offday.MaxLength = 20;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection ins = new SqlConnection("Data Source=ASAD;Initial Catalog=master;Integrated Security=True");
                string quarry = "insert into train values('"+Id.Text+"','"+Tname.Text+"','"+offday.Text+"','"+No_pass.Text+"','"+capacity.Text+"')";
                SqlCommand instrain = new SqlCommand(quarry, ins);
                ins.Open();
                instrain.ExecuteNonQuery();
                MessageBox.Show("Train info is added");
                this.DialogResult = DialogResult.OK;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void insert_train_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
