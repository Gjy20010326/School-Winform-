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
    public partial class 个人成绩 : Form
    {
        public 个人成绩()
        {
            InitializeComponent();
            
        }
        public int sid;
        StudentBll sb = new StudentBll();
        private void 个人成绩_Load(object sender, EventArgs e)
        {
            BindViem();
        }
        public void BindViem()
        {
            this.dataGridView1.DataSource = sb.SearchStuID(sid);
        }

    }
}
