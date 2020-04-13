namespace StuMSUI
{
    partial class 管理教师
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddPwd = new System.Windows.Forms.TextBox();
            this.AddtPro = new System.Windows.Forms.TextBox();
            this.AddName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddReset = new System.Windows.Forms.Button();
            this.AddSubmit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpdPwd = new System.Windows.Forms.TextBox();
            this.UpdtPro = new System.Windows.Forms.TextBox();
            this.UpdName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UpdReset = new System.Windows.Forms.Button();
            this.UpdSubmit = new System.Windows.Forms.Button();
            this.FormClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(904, 179);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tid";
            this.Column1.HeaderText = "教师编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tname";
            this.Column2.HeaderText = "教师姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "tprofession";
            this.Column3.HeaderText = "专业课程";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tpassword";
            this.Column4.HeaderText = "密码";
            this.Column4.Name = "Column4";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem,
            this.修改ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(406, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "教师报表";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddPwd);
            this.groupBox1.Controls.Add(this.AddtPro);
            this.groupBox1.Controls.Add(this.AddName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AddReset);
            this.groupBox1.Controls.Add(this.AddSubmit);
            this.groupBox1.Location = new System.Drawing.Point(12, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 291);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加";
            // 
            // AddPwd
            // 
            this.AddPwd.Location = new System.Drawing.Point(174, 173);
            this.AddPwd.Name = "AddPwd";
            this.AddPwd.Size = new System.Drawing.Size(170, 21);
            this.AddPwd.TabIndex = 9;
            // 
            // AddtPro
            // 
            this.AddtPro.Location = new System.Drawing.Point(174, 120);
            this.AddtPro.Name = "AddtPro";
            this.AddtPro.Size = new System.Drawing.Size(170, 21);
            this.AddtPro.TabIndex = 8;
            // 
            // AddName
            // 
            this.AddName.Location = new System.Drawing.Point(174, 72);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(170, 21);
            this.AddName.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "密码：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "职业：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "姓名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(191, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "添加界面";
            // 
            // AddReset
            // 
            this.AddReset.Location = new System.Drawing.Point(292, 235);
            this.AddReset.Name = "AddReset";
            this.AddReset.Size = new System.Drawing.Size(87, 36);
            this.AddReset.TabIndex = 2;
            this.AddReset.Text = "清空";
            this.AddReset.UseVisualStyleBackColor = true;
            this.AddReset.Click += new System.EventHandler(this.AddReset_Click);
            // 
            // AddSubmit
            // 
            this.AddSubmit.Location = new System.Drawing.Point(70, 235);
            this.AddSubmit.Name = "AddSubmit";
            this.AddSubmit.Size = new System.Drawing.Size(87, 36);
            this.AddSubmit.TabIndex = 0;
            this.AddSubmit.Text = "提交";
            this.AddSubmit.UseVisualStyleBackColor = true;
            this.AddSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.UpdPwd);
            this.groupBox2.Controls.Add(this.UpdtPro);
            this.groupBox2.Controls.Add(this.UpdName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.UpdReset);
            this.groupBox2.Controls.Add(this.UpdSubmit);
            this.groupBox2.Location = new System.Drawing.Point(464, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 291);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "管理";
            // 
            // UpdPwd
            // 
            this.UpdPwd.Location = new System.Drawing.Point(170, 173);
            this.UpdPwd.Name = "UpdPwd";
            this.UpdPwd.Size = new System.Drawing.Size(170, 21);
            this.UpdPwd.TabIndex = 9;
            // 
            // UpdtPro
            // 
            this.UpdtPro.Location = new System.Drawing.Point(170, 120);
            this.UpdtPro.Name = "UpdtPro";
            this.UpdtPro.Size = new System.Drawing.Size(170, 21);
            this.UpdtPro.TabIndex = 8;
            // 
            // UpdName
            // 
            this.UpdName.Location = new System.Drawing.Point(170, 72);
            this.UpdName.Name = "UpdName";
            this.UpdName.Size = new System.Drawing.Size(170, 21);
            this.UpdName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "密码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "职业：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 4;
            this.label8.Text = "姓名：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(205, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "修改界面";
            // 
            // UpdReset
            // 
            this.UpdReset.Location = new System.Drawing.Point(287, 235);
            this.UpdReset.Name = "UpdReset";
            this.UpdReset.Size = new System.Drawing.Size(87, 36);
            this.UpdReset.TabIndex = 2;
            this.UpdReset.Text = "清空";
            this.UpdReset.UseVisualStyleBackColor = true;
            this.UpdReset.Click += new System.EventHandler(this.UpdReset_Click);
            // 
            // UpdSubmit
            // 
            this.UpdSubmit.Location = new System.Drawing.Point(66, 235);
            this.UpdSubmit.Name = "UpdSubmit";
            this.UpdSubmit.Size = new System.Drawing.Size(87, 36);
            this.UpdSubmit.TabIndex = 0;
            this.UpdSubmit.Text = "提交";
            this.UpdSubmit.UseVisualStyleBackColor = true;
            this.UpdSubmit.Click += new System.EventHandler(this.UpdSubmit_Click);
            // 
            // FormClose
            // 
            this.FormClose.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormClose.Location = new System.Drawing.Point(340, 567);
            this.FormClose.Name = "FormClose";
            this.FormClose.Size = new System.Drawing.Size(257, 61);
            this.FormClose.TabIndex = 11;
            this.FormClose.Text = "关闭窗口";
            this.FormClose.UseVisualStyleBackColor = true;
            this.FormClose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // g教师报表
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(928, 643);
            this.Controls.Add(this.FormClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "g教师报表";
            this.Text = "教师报表";
            this.Load += new System.EventHandler(this.教师报表_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddReset;
        private System.Windows.Forms.Button AddSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.TextBox AddPwd;
        private System.Windows.Forms.TextBox AddtPro;
        private System.Windows.Forms.TextBox AddName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox UpdPwd;
        private System.Windows.Forms.TextBox UpdtPro;
        private System.Windows.Forms.TextBox UpdName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button UpdReset;
        private System.Windows.Forms.Button UpdSubmit;
        private System.Windows.Forms.ToolStripMenuItem 修改ToolStripMenuItem;
        private System.Windows.Forms.Button FormClose;
    }
}