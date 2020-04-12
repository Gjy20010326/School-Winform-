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
    public partial class g选课报表 : Form
    {
        public g选课报表()
        {
            InitializeComponent();
        }
        private SC_MappingBll scm = new SC_MappingBll();
        private void g选课报表_Load(object sender, EventArgs e)
        {
            BindViem();
        }
        public void BindViem()
        {
            this.dataGridView1.DataSource = scm.SelSC();
        }
    }
}
