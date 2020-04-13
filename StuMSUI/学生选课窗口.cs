using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StuMSDal;

namespace StuMSUI
{
    public partial class 学生选课窗口 : Form
    {
        public 学生选课窗口()
        {
            InitializeComponent();
        }

        private void FormClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Text!="")
            {
                SqlConnection conn = new SqlConnection(ADOTools.connStr);
                conn.Open();
                string sql = "select cname from course as c inner join teacher as t on t.tid=c.tid where tname ='" + this.comboBox1.Text+"'" ;
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dr.Read())
                {
                    this.comboBox2.Items.Add(dr["cname"]);
                }
                   

            }
        }

        private void 学生选课窗口_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ADOTools.connStr);
            conn.Open();
            string sql = "select tname,cname from  course as c inner join teacher as t on t.tid = c.tid";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dr.Read())
            {
                this.comboBox1.Items.Add(dr["tname"].ToString());
            }
        }
    }
}
