namespace StuMSUI
{
    partial class 管理员
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理学生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理教师ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.院系报表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课报表ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.管理学生ToolStripMenuItem,
            this.管理教师ToolStripMenuItem,
            this.课程报表ToolStripMenuItem,
            this.关闭ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(645, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 管理学生ToolStripMenuItem
            // 
            this.管理学生ToolStripMenuItem.Name = "管理学生ToolStripMenuItem";
            this.管理学生ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.管理学生ToolStripMenuItem.Text = "管理学生";
            this.管理学生ToolStripMenuItem.Click += new System.EventHandler(this.管理学生ToolStripMenuItem_Click);
            // 
            // 管理教师ToolStripMenuItem
            // 
            this.管理教师ToolStripMenuItem.Name = "管理教师ToolStripMenuItem";
            this.管理教师ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.管理教师ToolStripMenuItem.Text = "管理教师";
            this.管理教师ToolStripMenuItem.Click += new System.EventHandler(this.管理教师ToolStripMenuItem_Click);
            // 
            // 课程报表ToolStripMenuItem
            // 
            this.课程报表ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.院系报表ToolStripMenuItem,
            this.选课报表ToolStripMenuItem2});
            this.课程报表ToolStripMenuItem.Name = "课程报表ToolStripMenuItem";
            this.课程报表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.课程报表ToolStripMenuItem.Text = "数据报表";
            // 
            // 院系报表ToolStripMenuItem
            // 
            this.院系报表ToolStripMenuItem.Name = "院系报表ToolStripMenuItem";
            this.院系报表ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.院系报表ToolStripMenuItem.Text = "院系报表";
            this.院系报表ToolStripMenuItem.Click += new System.EventHandler(this.院系报表ToolStripMenuItem_Click);
            // 
            // 选课报表ToolStripMenuItem2
            // 
            this.选课报表ToolStripMenuItem2.Name = "选课报表ToolStripMenuItem2";
            this.选课报表ToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.选课报表ToolStripMenuItem2.Text = "选课报表";
            this.选课报表ToolStripMenuItem2.Click += new System.EventHandler(this.选课报表ToolStripMenuItem2_Click_1);
            // 
            // 关闭ToolStripMenuItem
            // 
            this.关闭ToolStripMenuItem.Name = "关闭ToolStripMenuItem";
            this.关闭ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关闭ToolStripMenuItem.Text = "关闭";
            this.关闭ToolStripMenuItem.Click += new System.EventHandler(this.关闭ToolStripMenuItem_Click);
            // 
            // 管理员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 492);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "管理员";
            this.Text = "管理员";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.管理员_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理学生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理教师ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 院系报表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课报表ToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 关闭ToolStripMenuItem;
    }
}