namespace SecurityClient.ui_design
{
    partial class ui_chat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.rtbx_receive_msg = new System.Windows.Forms.RichTextBox();
            this.btn_chat_history = new System.Windows.Forms.Button();
            this.tbx_send_msg = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btn_close_form = new System.Windows.Forms.Button();
            this.btn_send_msg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 460);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.rtbx_receive_msg);
            this.splitContainer1.Panel1.Controls.Add(this.btn_chat_history);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tbx_send_msg);
            this.splitContainer1.Size = new System.Drawing.Size(498, 458);
            this.splitContainer1.SplitterDistance = 326;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(325, 304);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "阅后即焚";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // rtbx_receive_msg
            // 
            this.rtbx_receive_msg.Location = new System.Drawing.Point(1, 1);
            this.rtbx_receive_msg.Name = "rtbx_receive_msg";
            this.rtbx_receive_msg.ReadOnly = true;
            this.rtbx_receive_msg.Size = new System.Drawing.Size(494, 293);
            this.rtbx_receive_msg.TabIndex = 6;
            this.rtbx_receive_msg.Text = "";
            // 
            // btn_chat_history
            // 
            this.btn_chat_history.Location = new System.Drawing.Point(406, 300);
            this.btn_chat_history.Name = "btn_chat_history";
            this.btn_chat_history.Size = new System.Drawing.Size(84, 23);
            this.btn_chat_history.TabIndex = 5;
            this.btn_chat_history.Text = "聊天记录";
            this.btn_chat_history.UseVisualStyleBackColor = true;
            this.btn_chat_history.Click += new System.EventHandler(this.btn_chat_history_Click);
            // 
            // tbx_send_msg
            // 
            this.tbx_send_msg.Location = new System.Drawing.Point(1, 1);
            this.tbx_send_msg.Multiline = true;
            this.tbx_send_msg.Name = "tbx_send_msg";
            this.tbx_send_msg.Size = new System.Drawing.Size(494, 128);
            this.tbx_send_msg.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox2);
            this.panel2.Location = new System.Drawing.Point(500, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 460);
            this.panel2.TabIndex = 1;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(1, 1);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(278, 458);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // btn_close_form
            // 
            this.btn_close_form.Location = new System.Drawing.Point(327, 466);
            this.btn_close_form.Name = "btn_close_form";
            this.btn_close_form.Size = new System.Drawing.Size(72, 23);
            this.btn_close_form.TabIndex = 2;
            this.btn_close_form.Text = "关闭";
            this.btn_close_form.UseVisualStyleBackColor = true;
            this.btn_close_form.Click += new System.EventHandler(this.btn_close_form_Click);
            // 
            // btn_send_msg
            // 
            this.btn_send_msg.Location = new System.Drawing.Point(408, 466);
            this.btn_send_msg.Name = "btn_send_msg";
            this.btn_send_msg.Size = new System.Drawing.Size(84, 23);
            this.btn_send_msg.TabIndex = 3;
            this.btn_send_msg.Text = "发送(Enter)";
            this.btn_send_msg.UseVisualStyleBackColor = true;
            this.btn_send_msg.Click += new System.EventHandler(this.btn_send_msg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(502, 468);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 21);
            this.textBox1.TabIndex = 4;
            // 
            // ui_chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(784, 492);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_send_msg);
            this.Controls.Add(this.btn_close_form);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "ui_chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "与 *** 聊天中";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ui_chat_FormClosing);
            this.Load += new System.EventHandler(this.ui_chat_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ui_chat_KeyDown);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_chat_history;
        private System.Windows.Forms.Button btn_close_form;
        private System.Windows.Forms.Button btn_send_msg;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbx_send_msg;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.RichTextBox rtbx_receive_msg;


    }
}