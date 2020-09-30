namespace Project8._8
{
    partial class FmLogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGo = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.BtnT2 = new System.Windows.Forms.Button();
            this.TxtBoxUser = new System.Windows.Forms.TextBox();
            this.TxtBoxPwd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(307, 150);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 24);
            this.BtnGo.TabIndex = 0;
            this.BtnGo.Text = "登录";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(307, 190);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 1;
            this.BtnBack.Text = "取消";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // BtnT2
            // 
            this.BtnT2.Location = new System.Drawing.Point(307, 228);
            this.BtnT2.Name = "BtnT2";
            this.BtnT2.Size = new System.Drawing.Size(75, 23);
            this.BtnT2.TabIndex = 2;
            this.BtnT2.Text = "注册";
            this.BtnT2.UseVisualStyleBackColor = true;
            this.BtnT2.Click += new System.EventHandler(this.BtnT2_Click);
            // 
            // TxtBoxUser
            // 
            this.TxtBoxUser.Location = new System.Drawing.Point(176, 150);
            this.TxtBoxUser.Name = "TxtBoxUser";
            this.TxtBoxUser.Size = new System.Drawing.Size(100, 21);
            this.TxtBoxUser.TabIndex = 3;
            // 
            // TxtBoxPwd
            // 
            this.TxtBoxPwd.Location = new System.Drawing.Point(176, 190);
            this.TxtBoxPwd.Name = "TxtBoxPwd";
            this.TxtBoxPwd.Size = new System.Drawing.Size(100, 21);
            this.TxtBoxPwd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码：";
            // 
            // FmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 420);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxPwd);
            this.Controls.Add(this.TxtBoxUser);
            this.Controls.Add(this.BtnT2);
            this.Controls.Add(this.BtnBack);
            this.Name = "FmLogin";
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.FmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Button BtnT2;
        private System.Windows.Forms.TextBox TxtBoxUser;
        private System.Windows.Forms.TextBox TxtBoxPwd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

