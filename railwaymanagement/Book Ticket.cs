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
    public partial class Book_Ticket : Form
    {
        int tid;
        DateTime d;
        public Book_Ticket(int tname,DateTime dt)
        {
            InitializeComponent();
            tid = tname;
            d = dt;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void print_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Option Is Under Maintenence");
        }
    }
}
