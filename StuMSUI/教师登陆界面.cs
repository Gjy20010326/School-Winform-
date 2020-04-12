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
    public partial class 教师登陆界面 : Form
    {
        public 教师登陆界面()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            登陆界面 d = new 登陆界面();
            d.Show();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherBll s = new TeacherBll();
            string tid = this.textBox1.Text;
            string tpwd = this.textBox2.Text;
            if (s.SelUsers(tid, tpwd))
            {
                MessageBox.Show("yes");
                教师 j = new 教师();
                j.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        private void 教师登陆界面_Load(object sender, EventArgs e)
        {

        }
    }
}
