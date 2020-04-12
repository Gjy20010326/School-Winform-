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
    
    public partial class 学生登陆界面 : Form
    {
        
        public 学生登陆界面()
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
            
            StudentBll sb = new StudentBll();
            string sid = this.textBox1.Text;
            string spwd = this.textBox2.Text;
            if (sb.SelStudent(sid, spwd))
            {
                MessageBox.Show("登陆成功！");
                学生 d = new 学生();
                d.sid = Convert.ToInt32(this.textBox1.Text);
                d.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("登陆失败!");
            }

        }
        public void SetText(string txt)
        {
            this.textBox2.Text = txt;
        }

        
        
    }
}
