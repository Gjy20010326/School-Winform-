using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuMSUI
{
    public partial class 教师 : Form
    {
        public 教师()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 录入成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            录入学生成绩 j = new 录入学生成绩();
            j.MdiParent = this;
            j.StartPosition = FormStartPosition.CenterScreen;
            ChangeChildren(j);
        }
        private void ChangeChildren(Form f)
        {
            if (this.MdiChildren.Length == 1)
            {
                f.Show();
                return;
            }
            foreach (Form children in this.MdiChildren)
            {
                if (f == children)
                {
                    children.Activate();
                    break;
                }
                else
                {
                    children.Close();
                    f.Show();
                    break;
                }
            }
        }

        private void 教师_Load(object sender, EventArgs e)
        {

        }

        private void 教师_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                //为保证Application.Exit();时不再弹出提示，所以将FormClosing事件取消
                this.FormClosing -= new FormClosingEventHandler(this.教师_FormClosing);
                Application.Exit();//退出整个应用程序
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
