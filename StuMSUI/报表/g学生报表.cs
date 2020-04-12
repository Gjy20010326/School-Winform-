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
using System.Data;
using StuMSModels;
using StuMSBll;

namespace StuMSUI
{
    public partial class g学生报表 : Form
    {
        public g学生报表()
        {
            InitializeComponent();
        }
        private Student s = new Student();
        private StudentBll sb = new StudentBll();
        public void BindViem()
        {
            this.dataGridView1.DataSource = sb.SelStudentList();
        }
        private void 学生报表_Load(object sender, EventArgs e)
        {
            BindViem();
        }
    }
}
