namespace StuMSUI
{
    partial class g学生报表
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.sname,
            this.sbirthday,
            this.ssex,
            this.spassword});
            this.dataGridView1.Location = new System.Drawing.Point(30, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(543, 262);
            this.dataGridView1.TabIndex = 0;
            // 
            // sid
            // 
            this.sid.DataPropertyName = "sid";
            this.sid.HeaderText = "学号";
            this.sid.Name = "sid";
            // 
            // sname
            // 
            this.sname.DataPropertyName = "sname";
            this.sname.HeaderText = "学生姓名";
            this.sname.Name = "sname";
            // 
            // sbirthday
            // 
            this.sbirthday.DataPropertyName = "sbirthday";
            this.sbirthday.HeaderText = "学生生日";
            this.sbirthday.Name = "sbirthday";
            // 
            // ssex
            // 
            this.ssex.DataPropertyName = "ssex";
            this.ssex.HeaderText = "学生性别";
            this.ssex.Name = "ssex";
            // 
            // spassword
            // 
            this.spassword.DataPropertyName = "spassword";
            this.spassword.HeaderText = "密码";
            this.spassword.Name = "spassword";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(228, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "学生报表";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(30, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 167);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管理";
            // 
            // g学生报表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "g学生报表";
            this.Text = "学生报表";
            this.Load += new System.EventHandler(this.学生报表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssex;
        private System.Windows.Forms.DataGridViewTextBoxColumn spassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}