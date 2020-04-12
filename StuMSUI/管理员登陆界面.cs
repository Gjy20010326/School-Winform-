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

namespace StuMSUI
{
    public partial class 管理员登陆界面 : Form
    {
        public 管理员登陆界面()
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
            System_UsersBll su = new System_UsersBll();
            string ucode = this.textBox1.Text;
            string upwd = this.textBox2.Text;
            if (su.SelUsers(ucode, upwd))
            {
                MessageBox.Show("yes");
                管理员 g = new 管理员();
                g.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("no");

            }

        }

        private void 管理员界面_Load(object sender, EventArgs e)
        {
            
        }
    }
}
