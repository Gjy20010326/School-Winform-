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
    public partial class 管理教师 : Form
    {
        public 管理教师()
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
                Tname=this.AddName.Text,
                TProfession=this.AddtPro.Text,
                TPassword=this.AddPwd.Text
            };
            if (tb.InsTeacher(t))
            {
                MessageBox.Show("成功！");
                this.AddName.Text = this.AddtPro.Text = this.AddPwd.Text = "";
                BindViem();
            }
            else
            {
                MessageBox.Show("失败！");
            }
        }

        

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.UpdName.Tag = this.dataGridView1.SelectedRows[0].Cells[0].Value;
            this.UpdName.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            this.UpdtPro.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            this.UpdPwd.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            
            
        }
        /// <summary>
        /// 添加的清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddReset_Click(object sender, EventArgs e)
        {
            this.AddName.Text = this.AddPwd.Text= this.AddtPro.Text= "";
        }
        /// <summary>
        /// 删除里的清空按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdReset_Click(object sender, EventArgs e)
        {
            this.UpdName.Text = this.UpdPwd.Text = this.UpdtPro.Text = "";
        }
        /// <summary>
        /// 修改按钮提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdSubmit_Click(object sender, EventArgs e)
        {
            Teacher t = new Teacher()
            {
                Tid = int.Parse(this.UpdName.Tag.ToString()),
                Tname=this.UpdName.Text,
                TProfession=this.UpdtPro.Text,
                TPassword=this.UpdPwd.Text
            };
            if (tb.UpdTeacher(t))
            {
                this.UpdName.Text = this.UpdPwd.Text = this.UpdtPro.Text = "";
                MessageBox.Show("成功！！！");
                BindViem();
            }
            else
            {
                MessageBox.Show("失败！！！");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
