﻿using System;
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

namespace StuMSUI
{
    public partial class 录入学生成绩 : Form
    {
        public 录入学生成绩()
        {
            InitializeComponent();
        }
        SC_MappingBll scb = new SC_MappingBll();
        private void j录入成绩_Load(object sender, EventArgs e)
        {
            BindViem();
        }
        public void BindViem()
        {
            this.dataGridView1.DataSource = scb.SelSC_Mapping3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != "" && this.textBox2.Text != "" && this.textBox3.Text != "")
            {
                int sid = Convert.ToInt32(this.textBox1.Text);
                int cid = Convert.ToInt32(this.textBox2.Text);
                int score = Convert.ToInt32(this.textBox3.Text);
                SC_Mapping sc = new SC_Mapping()
                {
                    Sid = sid,
                    Cid = cid,
                    Score = score
                };
                if (scb.UpdSC_Mapping(sc))
                {
                    MessageBox.Show("成功");
                    BindViem();
                }
                else
                {
                    MessageBox.Show("添加有错误");
                }
            }
            else
            {
                MessageBox.Show("不能有为空的！");
            }
           
        }

        private void FormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
