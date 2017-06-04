namespace SecurityClient.ui_design
{
    partial class ui_register
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_nickname = new System.Windows.Forms.TextBox();
            this.tbx_pw = new System.Windows.Forms.TextBox();
            this.tbx_pw_confirm = new System.Windows.Forms.TextBox();
            this.tbx_signature = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "昵称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "确认密码";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "个性签名";
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(70, 23);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(206, 21);
            this.tbx_username.TabIndex = 5;
            // 
            // tbx_nickname
            // 
            this.tbx_nickname.Location = new System.Drawing.Point(70, 58);
            this.tbx_nickname.Name = "tbx_nickname";
            this.tbx_nickname.Size = new System.Drawing.Size(206, 21);
            this.tbx_nickname.TabIndex = 6;
            // 
            // tbx_pw
            // 
            this.tbx_pw.Location = new System.Drawing.Point(70, 92);
            this.tbx_pw.Name = "tbx_pw";
            this.tbx_pw.PasswordChar = '*';
            this.tbx_pw.Size = new System.Drawing.Size(206, 21);
            this.tbx_pw.TabIndex = 7;
            // 
            // tbx_pw_confirm
            // 
            this.tbx_pw_confirm.Location = new System.Drawing.Point(82, 119);
            this.tbx_pw_confirm.Name = "tbx_pw_confirm";
            this.tbx_pw_confirm.PasswordChar = '*';
            this.tbx_pw_confirm.Size = new System.Drawing.Size(194, 21);
            this.tbx_pw_confirm.TabIndex = 8;
            // 
            // tbx_signature
            // 
            this.tbx_signature.Location = new System.Drawing.Point(82, 156);
            this.tbx_signature.Multiline = true;
            this.tbx_signature.Name = "tbx_signature";
            this.tbx_signature.Size = new System.Drawing.Size(194, 74);
            this.tbx_signature.TabIndex = 9;
            this.tbx_signature.Text = "这个人很懒，什么都没有留下";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(25, 251);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 10;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(201, 251);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(75, 23);
            this.btn_register.TabIndex = 11;
            this.btn_register.Text = "注册";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // ui_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 284);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tbx_signature);
            this.Controls.Add(this.tbx_pw_confirm);
            this.Controls.Add(this.tbx_pw);
            this.Controls.Add(this.tbx_nickname);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ui_register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "注册";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ui_register_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_nickname;
        private System.Windows.Forms.TextBox tbx_pw;
        private System.Windows.Forms.TextBox tbx_pw_confirm;
        private System.Windows.Forms.TextBox tbx_signature;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_register;
    }
}