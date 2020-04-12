using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using StuMSModels;
using StuMSBll;
using StuMSDal;

namespace StuMSUI
{
    public partial class 学生个人信息 : Form
    {
        public 学生个人信息()
        {
            InitializeComponent();
        }
        public int sid;
        private void 学生个人信息_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ADOTools.connStr);
            conn.Open();
            string sql = "select sid,sname, ssex from student where sid = " + sid;
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            try
            {
                while (dr.Read())
                {
                    this.label4.Text = sid.ToString();
                    this.label5.Text = dr["sname"].ToString();
                    if (dr["ssex"].ToString() == "1")
                    {
                        this.label6.Text = "男";
                    }
                    else
                    {
                        this.label6.Text = "女";
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

            }
           
        }
    }
}
