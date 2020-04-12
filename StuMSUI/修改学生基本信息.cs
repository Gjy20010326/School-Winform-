using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using StuMSModels;
using StuMSBll;
using StuMSDal;

namespace StuMSUI
{
    public partial class 修改学生基本信息 : Form
    {
        public 修改学生基本信息()
        {
            InitializeComponent();
        }
        public int id;
        private StudentBll sb = new StudentBll();
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "" && this.textBox2.Text != "" && this.textBox3.Text != "" && this.textBox4.Text != "")
            {
                if (this.textBox2.Text=="男")
                {
                    Student s = new Student()
                    {
                        Sid = id,
                        Sname = this.textBox1.Text,
                        Ssex = "1",
                        Sbirthday = this.textBox3.Text,
                        Spassword = this.textBox4.Text
                    };
                    if (sb.UpdStudent(s))
                    {
                        Console.WriteLine("成功！");
                        
                    }
                    else
                    {
                        Console.WriteLine("失败！");
                    }
                    this.Close();
                }
                else
                {
                    Student s = new Student()
                    {
                        Sid = id,
                        Sname = this.textBox1.Text,
                        Ssex = "0",
                        Sbirthday = this.textBox3.Text,
                        Spassword = this.textBox4.Text
                    };
                    if (sb.UpdStudent(s))
                    {
                        Console.WriteLine("成功！");
                        
                    }
                    else
                    {
                        Console.WriteLine("失败！");
                    }
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("保存的内容不能为空！！！");
            }
        }
        private void 修改学生基本信息_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ADOTools.connStr);
            conn.Open();
            string sql = "select sid,sname,sbirthday, ssex,spassword from student where sid = " + id;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                this.textBox1.Text = dr["sname"].ToString();
                if (dr["ssex"].ToString() == "1")
                {
                    this.textBox2.Text = "男";
                }
                else
                {
                    this.textBox2.Text = "女";
                }
                this.textBox3.Text = dr["sbirthday"].ToString();
                this.textBox4.Text = dr["spassword"].ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
