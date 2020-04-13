using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StuMSBll;
using StuMSModels;
using System.Data.SqlClient;
using StuMSDal;

namespace StuMSUI
{
    public partial class 学生 : Form
    {
        public 学生()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        学生登陆界面 s = new 学生登陆界面();
        StudentBll smb = new StudentBll();
        
        public int sid;
        public string spwd;
        private void 学生_Load(object sender, EventArgs e)
        {
            学生个人信息 x = new 学生个人信息();
            x.sid= sid ;
            x.MdiParent = this;
            x.StartPosition = FormStartPosition.CenterScreen;
            ChangeChildren(x);
        }
        /// <summary>
        /// 窗口超过一个就关闭之前的窗口
        /// </summary>
        /// <param name="f"></param>
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
        /// <summary>
        /// 点击修改密码窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdPassword up = new UpdPassword();
            up.sid = sid;
            up.spwd = spwd;
            up.MdiParent = this;
            up.StartPosition = FormStartPosition.CenterScreen;
            ChangeChildren(up);
        }
        /// <summary>
        /// 点击右上角关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 学生_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                //为保证Application.Exit();时不再弹出提示，所以将FormClosing事件取消
                this.FormClosing -= new FormClosingEventHandler(this.学生_FormClosing);
                Application.Exit();//退出整个应用程序
            }
            else
            {
                e.Cancel = true; //取消关闭事件
            }
        }

        private void 个人成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            个人成绩 g = new 个人成绩();
            g.sid = sid;
            g.MdiParent = this;
            g.StartPosition = FormStartPosition.CenterScreen;
            ChangeChildren(g);
        }

        private void 功能查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            学生选课窗口 xx = new 学生选课窗口();
            xx.MdiParent = this;
            xx.StartPosition = FormStartPosition.CenterScreen;
            ChangeChildren(xx);
        }
    }
}
