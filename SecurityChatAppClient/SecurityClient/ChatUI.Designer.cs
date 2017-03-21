namespace SecurityClient
{
    partial class ChatUI
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnectClient = new System.Windows.Forms.Button();
            this.tbxRcvMsg = new System.Windows.Forms.TextBox();
            this.tbxSendMsg = new System.Windows.Forms.TextBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConnectClient
            // 
            this.btnConnectClient.Location = new System.Drawing.Point(12, 12);
            this.btnConnectClient.Name = "btnConnectClient";
            this.btnConnectClient.Size = new System.Drawing.Size(75, 23);
            this.btnConnectClient.TabIndex = 0;
            this.btnConnectClient.Text = "Connect";
            this.btnConnectClient.UseVisualStyleBackColor = true;
            this.btnConnectClient.Click += new System.EventHandler(this.btnConnectClient_Click);
            // 
            // tbxRcvMsg
            // 
            this.tbxRcvMsg.Location = new System.Drawing.Point(12, 54);
            this.tbxRcvMsg.Multiline = true;
            this.tbxRcvMsg.Name = "tbxRcvMsg";
            this.tbxRcvMsg.Size = new System.Drawing.Size(561, 253);
            this.tbxRcvMsg.TabIndex = 1;
            // 
            // tbxSendMsg
            // 
            this.tbxSendMsg.Location = new System.Drawing.Point(12, 337);
            this.tbxSendMsg.Multiline = true;
            this.tbxSendMsg.Name = "tbxSendMsg";
            this.tbxSendMsg.Size = new System.Drawing.Size(561, 91);
            this.tbxSendMsg.TabIndex = 2;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(498, 434);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 3;
            this.btnSendMsg.Text = "Send";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // ChatUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 463);
            this.Controls.Add(this.btnSendMsg);
            this.Controls.Add(this.tbxSendMsg);
            this.Controls.Add(this.tbxRcvMsg);
            this.Controls.Add(this.btnConnectClient);
            this.Name = "ChatUI";
            this.Text = "Chat With Somebody";
            this.Load += new System.EventHandler(this.ChatUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectClient;
        private System.Windows.Forms.TextBox tbxSendMsg;
        private System.Windows.Forms.Button btnSendMsg;
        public System.Windows.Forms.TextBox tbxRcvMsg;
    }
}

