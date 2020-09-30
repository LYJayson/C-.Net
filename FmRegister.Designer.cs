namespace Project8._8
{
    partial class FmRegister
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
            this.BtnGo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtBoxPwd1 = new System.Windows.Forms.TextBox();
            this.TxtBoxUser = new System.Windows.Forms.TextBox();
            this.BtnT2 = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtBoxPwd2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnGo
            // 
            this.BtnGo.Location = new System.Drawing.Point(271, 138);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 24);
            this.BtnGo.TabIndex = 7;
            this.BtnGo.Text = "注册";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "用户名：";
            // 
            // TxtBoxPwd1
            // 
            this.TxtBoxPwd1.Location = new System.Drawing.Point(140, 178);
            this.TxtBoxPwd1.Name = "TxtBoxPwd1";
            this.TxtBoxPwd1.Size = new System.Drawing.Size(100, 21);
            this.TxtBoxPwd1.TabIndex = 11;
            // 
            // TxtBoxUser
            // 
            this.TxtBoxUser.Location = new System.Drawing.Point(140, 138);
            this.TxtBoxUser.Name = "TxtBoxUser";
            this.TxtBoxUser.Size = new System.Drawing.Size(100, 21);
            this.TxtBoxUser.TabIndex = 10;
            // 
            // BtnT2
            // 
            this.BtnT2.Location = new System.Drawing.Point(271, 216);
            this.BtnT2.Name = "BtnT2";
            this.BtnT2.Size = new System.Drawing.Size(75, 23);
            this.BtnT2.TabIndex = 9;
            this.BtnT2.Text = "返回登录";
            this.BtnT2.UseVisualStyleBackColor = true;
            this.BtnT2.Click += new System.EventHandler(this.BtnT2_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(271, 178);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 8;
            this.BtnBack.Text = "取消";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "密码：";
            // 
            // TxtBoxPwd2
            // 
            this.TxtBoxPwd2.Location = new System.Drawing.Point(140, 218);
            this.TxtBoxPwd2.Name = "TxtBoxPwd2";
            this.TxtBoxPwd2.Size = new System.Drawing.Size(100, 21);
            this.TxtBoxPwd2.TabIndex = 14;
            // 
            // FmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtBoxPwd2);
            this.Controls.Add(this.BtnGo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtBoxPwd1);
            this.Controls.Add(this.TxtBoxUser);
            this.Controls.Add(this.BtnT2);
            this.Controls.Add(this.BtnBack);
            this.Name = "FmRegister";
            this.Text = "新用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtBoxPwd1;
        private System.Windows.Forms.TextBox TxtBoxUser;
        private System.Windows.Forms.Button BtnT2;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtBoxPwd2;
    }
}