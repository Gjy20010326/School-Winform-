using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuMSUI
{
    public partial class 教师 : Form
    {
        public 教师()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void 录入成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            j录入成绩 j = new j录入成绩();
            j.MdiParent = this;
            j.StartPosition = FormStartPosition.CenterScreen;
            ChangeChildren(j);
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
