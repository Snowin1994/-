namespace SecurityClient.ui_design
{
    partial class ui_search_friends
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
            this.tbx_friend_username = new System.Windows.Forms.TextBox();
            this.btn_search_friend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_nickname = new System.Windows.Forms.TextBox();
            this.tbx_signature = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_add_friend = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_friend_username
            // 
            this.tbx_friend_username.Location = new System.Drawing.Point(59, 14);
            this.tbx_friend_username.Name = "tbx_friend_username";
            this.tbx_friend_username.Size = new System.Drawing.Size(194, 21);
            this.tbx_friend_username.TabIndex = 0;
            // 
            // btn_search_friend
            // 
            this.btn_search_friend.Location = new System.Drawing.Point(259, 12);
            this.btn_search_friend.Name = "btn_search_friend";
            this.btn_search_friend.Size = new System.Drawing.Size(65, 23);
            this.btn_search_friend.TabIndex = 1;
            this.btn_search_friend.Text = "查找";
            this.btn_search_friend.UseVisualStyleBackColor = true;
            this.btn_search_friend.Click += new System.EventHandler(this.btn_search_friend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_signature);
            this.groupBox1.Controls.Add(this.tbx_nickname);
            this.groupBox1.Controls.Add(this.tbx_username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 179);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找结果";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "昵称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "签名";
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(57, 30);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(237, 21);
            this.tbx_username.TabIndex = 3;
            // 
            // tbx_nickname
            // 
            this.tbx_nickname.Location = new System.Drawing.Point(57, 70);
            this.tbx_nickname.Name = "tbx_nickname";
            this.tbx_nickname.Size = new System.Drawing.Size(237, 21);
            this.tbx_nickname.TabIndex = 4;
            // 
            // tbx_signature
            // 
            this.tbx_signature.Location = new System.Drawing.Point(57, 119);
            this.tbx_signature.Multiline = true;
            this.tbx_signature.Name = "tbx_signature";
            this.tbx_signature.Size = new System.Drawing.Size(237, 51);
            this.tbx_signature.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "请输入";
            // 
            // btn_add_friend
            // 
            this.btn_add_friend.Location = new System.Drawing.Point(259, 217);
            this.btn_add_friend.Name = "btn_add_friend";
            this.btn_add_friend.Size = new System.Drawing.Size(65, 23);
            this.btn_add_friend.TabIndex = 7;
            this.btn_add_friend.Text = "添加";
            this.btn_add_friend.UseVisualStyleBackColor = true;
            this.btn_add_friend.Click += new System.EventHandler(this.btn_add_friend_Click);
            // 
            // ui_search_friends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 246);
            this.Controls.Add(this.btn_add_friend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_search_friend);
            this.Controls.Add(this.tbx_friend_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ui_search_friends";
            this.Text = "查找好友";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ui_search_friends_FormClosing);
            this.Load += new System.EventHandler(this.ui_search_friends_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_friend_username;
        private System.Windows.Forms.Button btn_search_friend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_signature;
        private System.Windows.Forms.TextBox tbx_nickname;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_add_friend;
    }
}