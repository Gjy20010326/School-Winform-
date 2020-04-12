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
    public partial class g院系报表 : Form
    {
        public g院系报表()
        {
            InitializeComponent();
        }
        private SC_MappingBll sb = new SC_MappingBll();
        private void 院系报表_Load(object sender, EventArgs e)
        {
            BindViem();
        }
        public void BindViem()
        {
            this.dataGridView1.DataSource = sb.SelSC_Mapping();
        }
    }
}
