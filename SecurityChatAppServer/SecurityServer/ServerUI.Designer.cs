namespace SecurityServer
{
    partial class ServerUI
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
            this.btnConnectServer = new System.Windows.Forms.Button();
            this.tbxStatusBox = new System.Windows.Forms.TextBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnectServer
            // 
            this.btnConnectServer.Location = new System.Drawing.Point(413, 60);
            this.btnConnectServer.Name = "btnConnectServer";
            this.btnConnectServer.Size = new System.Drawing.Size(75, 23);
            this.btnConnectServer.TabIndex = 0;
            this.btnConnectServer.Text = "Connect";
            this.btnConnectServer.UseVisualStyleBackColor = true;
            this.btnConnectServer.Click += new System.EventHandler(this.btnConnectServer_Click);
            // 
            // tbxStatusBox
            // 
            this.tbxStatusBox.Location = new System.Drawing.Point(12, 12);
            this.tbxStatusBox.Multiline = true;
            this.tbxStatusBox.Name = "tbxStatusBox";
            this.tbxStatusBox.Size = new System.Drawing.Size(382, 71);
            this.tbxStatusBox.TabIndex = 1;
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(446, 12);
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(42, 21);
            this.tbxPort.TabIndex = 2;
            this.tbxPort.Text = "2017";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "port";
            // 
            // ServerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxPort);
            this.Controls.Add(this.tbxStatusBox);
            this.Controls.Add(this.btnConnectServer);
            this.Name = "ServerUI";
            this.Text = "SecurityServer";
            this.Load += new System.EventHandler(this.ServerUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnectServer;
        private System.Windows.Forms.TextBox tbxStatusBox;
        private System.Windows.Forms.TextBox tbxPort;
        private System.Windows.Forms.Label label1;
    }
}

