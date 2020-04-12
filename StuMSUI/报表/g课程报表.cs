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
using System.Data;

namespace StuMSUI
{
    public partial class g课程报表 : Form
    {
        public g课程报表()
        {
            InitializeComponent();
        }
        private TeacherBll tb = new TeacherBll();
        private CourseBll cb = new CourseBll();
        public void BindViem()
        {
            this.dataGridView1.DataSource = cb.SelCourseDT();
        }
        private void 课程报表_Load(object sender, EventArgs e)
        {
            BindViem();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cid = this.textBox1.Text;
            string tname = this.textBox2.Text;
            string cname = this.textBox3.Text;
            this.dataGridView1.DataSource = cb.SelCT(Convert.ToInt32(cid), tname, cname);


        }
    }
}
