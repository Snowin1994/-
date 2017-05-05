namespace SecurityClient.ui_design
{
    partial class ui_update_password
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
            this.tbx_old_pw = new System.Windows.Forms.TextBox();
            this.tbx_new_pw = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_new_re_pw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // tbx_old_pw
            // 
            this.tbx_old_pw.Location = new System.Drawing.Point(73, 18);
            this.tbx_old_pw.Name = "tbx_old_pw";
            this.tbx_old_pw.Size = new System.Drawing.Size(145, 21);
            this.tbx_old_pw.TabIndex = 1;
            this.tbx_old_pw.UseSystemPasswordChar = true;
            // 
            // tbx_new_pw
            // 
            this.tbx_new_pw.Location = new System.Drawing.Point(73, 67);
            this.tbx_new_pw.Name = "tbx_new_pw";
            this.tbx_new_pw.Size = new System.Drawing.Size(145, 21);
            this.tbx_new_pw.TabIndex = 3;
            this.tbx_new_pw.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "新密码";
            // 
            // tbx_new_re_pw
            // 
            this.tbx_new_re_pw.Location = new System.Drawing.Point(73, 94);
            this.tbx_new_re_pw.Name = "tbx_new_re_pw";
            this.tbx_new_re_pw.Size = new System.Drawing.Size(145, 21);
            this.tbx_new_re_pw.TabIndex = 5;
            this.tbx_new_re_pw.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "确认密码";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(73, 144);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(145, 23);
            this.btn_update.TabIndex = 6;
            this.btn_update.Text = "确认";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // ui_update_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 179);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.tbx_new_re_pw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_new_pw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbx_old_pw);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ui_update_password";
            this.Text = "修改密码";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ui_update_password_FormClosing);
            this.Load += new System.EventHandler(this.ui_update_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_old_pw;
        private System.Windows.Forms.TextBox tbx_new_pw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_new_re_pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_update;
    }
}