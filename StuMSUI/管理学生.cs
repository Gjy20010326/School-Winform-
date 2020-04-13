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
namespace StuMSUI
{
    public partial class 管理学生 : Form
    {
        public 管理学生()
        {
            InitializeComponent();
        }
        private SC_MappingBll sb = new SC_MappingBll();
        private StudentBll s = new StudentBll();
        private void 管理学生_Load(object sender, EventArgs e)
        {
            BindViem();
        }
        public void BindViem()
        {
            this.dataGridView1.DataSource = sb.SelSC_Mapping2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            if (name == "")
            {
                this.dataGridView1.DataSource = sb.SelSC_Mapping2();
            }
            else
            {
                this.dataGridView1.DataSource = s.SelStudentName(name);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sname = this.textBox3.Text;
            string sbirthday = this.dateTimePicker1.Value.ToString();
            string spassword = this.textBox4.Text;
            if (sname != "" && sbirthday != "" && spassword != "")
            {
                Student sa = new Student()
                {
                    Sname = sname,
                    Sbirthday = sbirthday,
                    Ssex = this.radioButton1.Checked ? "1" : "0",
                    Spassword = spassword
                };
                if (s.InsStudent(sa))
                {
                    MessageBox.Show("添加成功");
                    BindViem();
                }
            }
            else
            {
                MessageBox.Show("不能有为空的！");
            }
            
            
            
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
            if (s.DelStudent(cid))
            {
                MessageBox.Show("yes");
                BindViem();
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        /// <summary>
        /// 修改学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            修改学生基本信息 x = new 修改学生基本信息();
            x.id= Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
            x.StartPosition = FormStartPosition.CenterScreen;
            x.Show();
        }
        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BindViem();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
