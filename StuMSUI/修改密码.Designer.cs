namespace StuMSUI
{
    partial class UpdPassword
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OldPwd = new System.Windows.Forms.TextBox();
            this.YoungPwd = new System.Windows.Forms.TextBox();
            this.YoungPwd2 = new System.Windows.Forms.TextBox();
            this.UpdSubmit = new System.Windows.Forms.Button();
            this.UpdReset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新的密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确定密码：";
            // 
            // OldPwd
            // 
            this.OldPwd.Location = new System.Drawing.Point(160, 112);
            this.OldPwd.Name = "OldPwd";
            this.OldPwd.Size = new System.Drawing.Size(142, 21);
            this.OldPwd.TabIndex = 3;
            // 
            // YoungPwd
            // 
            this.YoungPwd.Location = new System.Drawing.Point(160, 178);
            this.YoungPwd.Name = "YoungPwd";
            this.YoungPwd.Size = new System.Drawing.Size(142, 21);
            this.YoungPwd.TabIndex = 4;
            // 
            // YoungPwd2
            // 
            this.YoungPwd2.Location = new System.Drawing.Point(160, 247);
            this.YoungPwd2.Name = "YoungPwd2";
            this.YoungPwd2.Size = new System.Drawing.Size(142, 21);
            this.YoungPwd2.TabIndex = 5;
            // 
            // UpdSubmit
            // 
            this.UpdSubmit.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UpdSubmit.Location = new System.Drawing.Point(22, 326);
            this.UpdSubmit.Name = "UpdSubmit";
            this.UpdSubmit.Size = new System.Drawing.Size(110, 47);
            this.UpdSubmit.TabIndex = 6;
            this.UpdSubmit.Text = "提交";
            this.UpdSubmit.UseVisualStyleBackColor = true;
            this.UpdSubmit.Click += new System.EventHandler(this.UpdSubmit_Click);
            // 
            // UpdReset
            // 
            this.UpdReset.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UpdReset.Location = new System.Drawing.Point(146, 326);
            this.UpdReset.Name = "UpdReset";
            this.UpdReset.Size = new System.Drawing.Size(110, 47);
            this.UpdReset.TabIndex = 7;
            this.UpdReset.Text = "清空";
            this.UpdReset.UseVisualStyleBackColor = true;
            this.UpdReset.Click += new System.EventHandler(this.UpdReset_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(268, 326);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 47);
            this.button3.TabIndex = 8;
            this.button3.Text = "关闭窗口";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(156, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "修改密码";
            // 
            // UpdPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 405);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.UpdReset);
            this.Controls.Add(this.UpdSubmit);
            this.Controls.Add(this.YoungPwd2);
            this.Controls.Add(this.YoungPwd);
            this.Controls.Add(this.OldPwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UpdPassword";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OldPwd;
        private System.Windows.Forms.TextBox YoungPwd;
        private System.Windows.Forms.TextBox YoungPwd2;
        private System.Windows.Forms.Button UpdSubmit;
        private System.Windows.Forms.Button UpdReset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}