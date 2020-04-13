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

namespace StuMSUI
{
    public partial class UpdPassword : Form
    {
        public UpdPassword()
        {
            InitializeComponent();
        }
        public int sid;
        public string spwd;
        public StudentBll sb = new StudentBll();
        private void UpdSubmit_Click(object sender, EventArgs e)
        {
            if (this.OldPwd.Text != "" && this.YoungPwd.Text != "" && this.YoungPwd2.Text != "")
            {
                if (this.OldPwd.Text == spwd)
                {
                    if (this.OldPwd.Text != this.YoungPwd.Text)
                    {
                        if (this.YoungPwd.Text == this.YoungPwd2.Text)
                        {
                            if (sb.UpdStudentPwd(this.YoungPwd.Text, sid))
                            {
                                MessageBox.Show("修改成功！");
                            }
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("输入的两次密码不一致！！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("原始密码与新密码不可一致！！");
                    }
                }
                else
                {
                    MessageBox.Show("输入的密码与原始密码不一样！！");
                }
            }
            else
            {
                MessageBox.Show("文本框不能为空！！！");
            }
            
        }

        private void UpdReset_Click(object sender, EventArgs e)
        {
            this.OldPwd.Text = this.YoungPwd.Text = this.YoungPwd2.Text = "";
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
