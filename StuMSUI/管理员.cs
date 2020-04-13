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
    public partial class 管理员 : Form
    {
        
        public 管理员()
        {
            
            InitializeComponent();
        }

        
        /// <summary>
        /// 点击院系报表按钮打开院系报表界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 院系报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g院系报表 y = new g院系报表();
            y.MdiParent = this;
            y.StartPosition = FormStartPosition.CenterScreen;
            ChangeChildren(y);
        }
        /// <summary>
        /// 点击选课报表按钮打开选课报表界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 选课报表ToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            g选课报表 c = new g选课报表();
            c.MdiParent = this;
            c.StartPosition = FormStartPosition.CenterScreen;
            ChangeChildren(c);
        }/// <summary>
        /// 当打开界面大于一个的时候，关闭之前界面，打开现在界面
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
        /// 点击管理学生按钮打开管理学生界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 管理学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            管理学生 g = new 管理学生();
            g.MdiParent = this;
            g.StartPosition = FormStartPosition.CenterScreen;
            ChangeChildren(g);
        }
        /// <summary>
        /// 右上角关闭按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 管理员_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                //为保证Application.Exit();时不再弹出提示，所以将FormClosing事件取消
                this.FormClosing -= new FormClosingEventHandler(this.管理员_FormClosing);
                Application.Exit();//退出整个应用程序
            }
            else
            {
                e.Cancel = true; //取消关闭事件
            }
        }

        private void 管理教师ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            管理教师 s = new 管理教师();
            s.MdiParent = this;
            s.StartPosition = FormStartPosition.CenterScreen;
            ChangeChildren(s);
        }

        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                //为保证Application.Exit();时不再弹出提示，所以将FormClosing事件取消
                this.FormClosing -= new FormClosingEventHandler(this.管理员_FormClosing);
                Application.Exit();//退出整个应用程序
            }
            
        }
   
    }
}
