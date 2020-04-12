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
    public partial class 登陆界面 : Form
    {
        public 登陆界面()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            学生登陆界面 d = new 学生登陆界面();
            d.Show();
            this.Visible = false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            教师登陆界面 j = new 教师登陆界面();
            j.Show();
            this.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            管理员登陆界面 g = new 管理员登陆界面();
            g.Show();
            this.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.OK == MessageBox.Show("你确定要关闭应用程序吗？", "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                System.Environment.Exit(0);
            }
            
        }

        private void 登陆界面_Load(object sender, EventArgs e)
        {

        }
    }
}
