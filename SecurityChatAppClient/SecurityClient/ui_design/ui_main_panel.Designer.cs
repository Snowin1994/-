namespace SecurityClient.ui_design
{
    partial class ui_main_panel
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsb_friends = new System.Windows.Forms.ListBox();
            this.cmenus_friend_setting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmenu_item_send_msg = new System.Windows.Forms.ToolStripMenuItem();
            this.tmenu_item_update_note = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmenus_setting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.选项1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmenu_update_password = new System.Windows.Forms.ToolStripMenuItem();
            this.tmenu_update_phonenum = new System.Windows.Forms.ToolStripMenuItem();
            this.tmenu_switch_user = new System.Windows.Forms.ToolStripMenuItem();
            this.pbx_search_friends = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbx_user_icon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.cmenus_friend_setting.SuspendLayout();
            this.cmenus_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_search_friends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_user_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(87, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "黑夜秋日";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(90, 60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(178, 37);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "凡事不要想的太复杂，想多头疼，想通心疼。手不要握的太紧，东西会碎，手会疼。";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lsb_friends);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Location = new System.Drawing.Point(-1, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 447);
            this.panel1.TabIndex = 6;
            // 
            // lsb_friends
            // 
            this.lsb_friends.ContextMenuStrip = this.cmenus_friend_setting;
            this.lsb_friends.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lsb_friends.FormattingEnabled = true;
            this.lsb_friends.ItemHeight = 21;
            this.lsb_friends.Location = new System.Drawing.Point(2, 22);
            this.lsb_friends.Name = "lsb_friends";
            this.lsb_friends.Size = new System.Drawing.Size(276, 424);
            this.lsb_friends.TabIndex = 1;
            this.lsb_friends.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsb_friends_MouseClick);
            // 
            // cmenus_friend_setting
            // 
            this.cmenus_friend_setting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmenu_item_send_msg,
            this.tmenu_item_update_note,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.cmenus_friend_setting.Name = "cmenus_friend_setting";
            this.cmenus_friend_setting.ShowCheckMargin = true;
            this.cmenus_friend_setting.Size = new System.Drawing.Size(171, 92);
            // 
            // tmenu_item_send_msg
            // 
            this.tmenu_item_send_msg.Name = "tmenu_item_send_msg";
            this.tmenu_item_send_msg.Size = new System.Drawing.Size(170, 22);
            this.tmenu_item_send_msg.Text = "发送即时消息";
            this.tmenu_item_send_msg.Click += new System.EventHandler(this.tmenu_item_send_msg_Click);
            // 
            // tmenu_item_update_note
            // 
            this.tmenu_item_update_note.Name = "tmenu_item_update_note";
            this.tmenu_item_update_note.Size = new System.Drawing.Size(170, 22);
            this.tmenu_item_update_note.Text = "修改备注信息";
            this.tmenu_item_update_note.Click += new System.EventHandler(this.tmenu_item_update_note_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem4.Text = "删除好友";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem5.Text = "加入黑名单";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-1, 0);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(280, 21);
            this.textBox2.TabIndex = 0;
            // 
            // cmenus_setting
            // 
            this.cmenus_setting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选项1ToolStripMenuItem,
            this.tmenu_update_password,
            this.tmenu_update_phonenum,
            this.tmenu_switch_user});
            this.cmenus_setting.Name = "cmenus_setting";
            this.cmenus_setting.Size = new System.Drawing.Size(153, 114);
            // 
            // 选项1ToolStripMenuItem
            // 
            this.选项1ToolStripMenuItem.Name = "选项1ToolStripMenuItem";
            this.选项1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.选项1ToolStripMenuItem.Text = "清空历史消息";
            // 
            // tmenu_update_password
            // 
            this.tmenu_update_password.Name = "tmenu_update_password";
            this.tmenu_update_password.Size = new System.Drawing.Size(152, 22);
            this.tmenu_update_password.Text = "修改密码";
            this.tmenu_update_password.Click += new System.EventHandler(this.tmenu_update_password_Click);
            // 
            // tmenu_update_phonenum
            // 
            this.tmenu_update_phonenum.Name = "tmenu_update_phonenum";
            this.tmenu_update_phonenum.Size = new System.Drawing.Size(152, 22);
            this.tmenu_update_phonenum.Text = "修改手机号";
            // 
            // tmenu_switch_user
            // 
            this.tmenu_switch_user.Name = "tmenu_switch_user";
            this.tmenu_switch_user.Size = new System.Drawing.Size(152, 22);
            this.tmenu_switch_user.Text = "切换用户";
            this.tmenu_switch_user.Click += new System.EventHandler(this.tmenu_switch_user_Click);
            // 
            // pbx_search_friends
            // 
            this.pbx_search_friends.Image = global::SecurityClient.Properties.Resources.add_set;
            this.pbx_search_friends.Location = new System.Drawing.Point(34, 563);
            this.pbx_search_friends.Name = "pbx_search_friends";
            this.pbx_search_friends.Size = new System.Drawing.Size(24, 24);
            this.pbx_search_friends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_search_friends.TabIndex = 9;
            this.pbx_search_friends.TabStop = false;
            this.pbx_search_friends.Click += new System.EventHandler(this.pbx_search_friends_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.cmenus_setting;
            this.pictureBox1.Image = global::SecurityClient.Properties.Resources.setting;
            this.pictureBox1.Location = new System.Drawing.Point(4, 563);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pbx_user_icon
            // 
            this.pbx_user_icon.Image = global::SecurityClient.Properties.Resources.default_head_pic;
            this.pbx_user_icon.Location = new System.Drawing.Point(17, 33);
            this.pbx_user_icon.Name = "pbx_user_icon";
            this.pbx_user_icon.Size = new System.Drawing.Size(64, 64);
            this.pbx_user_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_user_icon.TabIndex = 2;
            this.pbx_user_icon.TabStop = false;
            this.pbx_user_icon.Click += new System.EventHandler(this.pbx_user_icon_Click);
            // 
            // ui_main_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 589);
            this.Controls.Add(this.pbx_search_friends);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbx_user_icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ui_main_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "主界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ui_main_panel_FormClosing);
            this.Load += new System.EventHandler(this.ui_main_panel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmenus_friend_setting.ResumeLayout(false);
            this.cmenus_setting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_search_friends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_user_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_user_icon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox lsb_friends;
        private System.Windows.Forms.ContextMenuStrip cmenus_setting;
        private System.Windows.Forms.ToolStripMenuItem 选项1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tmenu_update_password;
        private System.Windows.Forms.ToolStripMenuItem tmenu_update_phonenum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tmenu_switch_user;
        private System.Windows.Forms.ContextMenuStrip cmenus_friend_setting;
        private System.Windows.Forms.ToolStripMenuItem tmenu_item_send_msg;
        private System.Windows.Forms.ToolStripMenuItem tmenu_item_update_note;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.PictureBox pbx_search_friends;
    }
}