﻿namespace SecurityClient.ui_design
{
    partial class ui_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ui_login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLbl_register = new System.Windows.Forms.LinkLabel();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Controls.Add(this.linkLabel2);
            this.panel1.Controls.Add(this.linkLbl_register);
            this.panel1.Controls.Add(this.tbx_password);
            this.panel1.Controls.Add(this.tbx_username);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(-6, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 137);
            this.panel1.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(74, 92);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(213, 28);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkColor = System.Drawing.Color.Teal;
            this.linkLabel2.Location = new System.Drawing.Point(266, 59);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(53, 12);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "找回密码";
            // 
            // linkLbl_register
            // 
            this.linkLbl_register.AutoSize = true;
            this.linkLbl_register.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLbl_register.LinkColor = System.Drawing.Color.Teal;
            this.linkLbl_register.Location = new System.Drawing.Point(265, 30);
            this.linkLbl_register.Name = "linkLbl_register";
            this.linkLbl_register.Size = new System.Drawing.Size(53, 12);
            this.linkLbl_register.TabIndex = 4;
            this.linkLbl_register.TabStop = true;
            this.linkLbl_register.Text = "注册帐号";
            this.linkLbl_register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_register_LinkClicked);
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(136, 51);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.PasswordChar = '*';
            this.tbx_password.Size = new System.Drawing.Size(123, 21);
            this.tbx_password.TabIndex = 3;
            this.tbx_password.Text = "1234";
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(136, 21);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(123, 21);
            this.tbx_username.TabIndex = 2;
            this.tbx_username.Text = "snowin1994";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SecurityClient.Properties.Resources.default_head_pic;
            this.pictureBox2.Location = new System.Drawing.Point(49, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SecurityClient.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(150, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ui_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(360, 245);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ui_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ui_login_FormClosing);
            this.Load += new System.EventHandler(this.ui_login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ui_login_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLbl_register;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}