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
        private CourseBll cb = new CourseBll();
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
            int tid = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
            
            if (cb.DelCourseByTid(tid)>0 || cb.DelCourseByTid(tid) ==0)
            {
                if (tb.DelTeacher(tid) ) {
                    MessageBox.Show("yes");
                    BindViem();
                }
            }
            else
            {
                MessageBox.Show("no");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher()
            {
                Tname=this.textBox1.Text,
                TProfession=this.textBox2.Text,
                TPassword=this.textBox3.Text
            };
            if (tb.InsTeacher(t))
            {
                MessageBox.Show("成功！");
                this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = "";
                BindViem();
            }
            else
            {
                MessageBox.Show("失败！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }
    }
}
