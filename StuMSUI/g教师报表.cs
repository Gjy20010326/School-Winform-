using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StuMSModels;
using StuMSBll;
using System.Data.SqlClient;

namespace StuMSUI
{
    public partial class g教师报表 : Form
    {
        public g教师报表()
        {
            InitializeComponent();
        }
        private TeacherBll tb = new TeacherBll();
        public void BindViem()
        {
            this.dataGridView1.DataSource = tb.SelTeacher();
        }
        private void 教师报表_Load(object sender, EventArgs e)
        {
            BindViem();
        }

        

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
            if (tb.DelTeacher(cid))
            {
                MessageBox.Show("yes");
                BindViem();
            }
            else
            {
                MessageBox.Show("no");
            }
        }
    }
}
