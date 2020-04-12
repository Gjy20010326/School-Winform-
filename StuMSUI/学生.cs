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
        
        private void 学生_Load(object sender, EventArgs e)
        {
            学生个人信息 x = new 学生个人信息();
            x.sid= sid ;
            x.MdiParent = this;
            x.StartPosition = FormStartPosition.CenterScreen;
            ChangeChildren(x);
        }
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

    }
}
