using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace railwaymanagement
{
    public partial class demo : Form
    {
        public demo(DataTable dt)
        {
            InitializeComponent();
            BindingSource bsourse = new BindingSource();
            bsourse.DataSource = dt;
            table.DataSource = bsourse;
        }

        private void demo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
