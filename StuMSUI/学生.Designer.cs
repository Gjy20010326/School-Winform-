namespace StuMSUI
{
    partial class 学生
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
            this.功能查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课功能ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.功能查询ToolStripMenuItem,
            this.浏览功能ToolStripMenuItem,
            this.选课功能ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(690, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 功能查询ToolStripMenuItem
            // 
            this.功能查询ToolStripMenuItem.Name = "功能查询ToolStripMenuItem";
            this.功能查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.功能查询ToolStripMenuItem.Text = "功能查询";
            // 
            // 浏览功能ToolStripMenuItem
            // 
            this.浏览功能ToolStripMenuItem.Name = "浏览功能ToolStripMenuItem";
            this.浏览功能ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.浏览功能ToolStripMenuItem.Text = "浏览功能";
            // 
            // 选课功能ToolStripMenuItem
            // 
            this.选课功能ToolStripMenuItem.Name = "选课功能ToolStripMenuItem";
            this.选课功能ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.选课功能ToolStripMenuItem.Text = "选课功能";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 学生
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 426);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "学生";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生登陆界面";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.学生_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课功能ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
    }
}