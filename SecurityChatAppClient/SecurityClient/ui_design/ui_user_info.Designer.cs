namespace SecurityClient.ui_design
{
    partial class ui_user_info
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_signature = new System.Windows.Forms.TextBox();
            this.tbx_nickname = new System.Windows.Forms.TextBox();
            this.btn_commit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SecurityClient.Properties.Resources.default_head_pic;
            this.pictureBox2.Location = new System.Drawing.Point(23, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "昵称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "签名";
            // 
            // tbx_signature
            // 
            this.tbx_signature.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbx_signature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_signature.Location = new System.Drawing.Point(140, 50);
            this.tbx_signature.Multiline = true;
            this.tbx_signature.Name = "tbx_signature";
            this.tbx_signature.Size = new System.Drawing.Size(174, 62);
            this.tbx_signature.TabIndex = 6;
            this.tbx_signature.Text = "凡事不要想的太复杂，想多头疼，想通心疼。手不要握的太紧，东西会碎，手会疼。";
            // 
            // tbx_nickname
            // 
            this.tbx_nickname.Location = new System.Drawing.Point(140, 20);
            this.tbx_nickname.Name = "tbx_nickname";
            this.tbx_nickname.Size = new System.Drawing.Size(174, 21);
            this.tbx_nickname.TabIndex = 7;
            this.tbx_nickname.Text = "黑夜秋日";
            // 
            // btn_commit
            // 
            this.btn_commit.Location = new System.Drawing.Point(140, 136);
            this.btn_commit.Name = "btn_commit";
            this.btn_commit.Size = new System.Drawing.Size(75, 23);
            this.btn_commit.TabIndex = 8;
            this.btn_commit.Text = "确认";
            this.btn_commit.UseVisualStyleBackColor = true;
            this.btn_commit.Click += new System.EventHandler(this.btn_commit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(239, 136);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // ui_user_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 169);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_commit);
            this.Controls.Add(this.tbx_nickname);
            this.Controls.Add(this.tbx_signature);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ui_user_info";
            this.Text = "个人信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ui_user_info_FormClosing);
            this.Load += new System.EventHandler(this.ui_user_info_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_signature;
        private System.Windows.Forms.TextBox tbx_nickname;
        private System.Windows.Forms.Button btn_commit;
        private System.Windows.Forms.Button btn_cancel;
    }
}