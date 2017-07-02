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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ui_main_panel));
            this.lbl_nickname = new System.Windows.Forms.Label();
            this.tbx_signature = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lsb_friends = new System.Windows.Forms.ListBox();
            this.cmenus_friend_setting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmenu_item_send_msg = new System.Windows.Forms.ToolStripMenuItem();
            this.tmenu_item_update_note = new System.Windows.Forms.ToolStripMenuItem();
            this.tmenu_item_delete_friend = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cmenus_setting = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tmenu_update_password = new System.Windows.Forms.ToolStripMenuItem();
            this.tmenu_switch_user = new System.Windows.Forms.ToolStripMenuItem();
            this.pbx_search_friends = new System.Windows.Forms.PictureBox();
            this.picBox_setting = new System.Windows.Forms.PictureBox();
            this.picBox_user_icon = new System.Windows.Forms.PictureBox();
            this.tip_main_panel = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.cmenus_friend_setting.SuspendLayout();
            this.cmenus_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_search_friends)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_setting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_user_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nickname
            // 
            this.lbl_nickname.AutoSize = true;
            this.lbl_nickname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nickname.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_nickname.Location = new System.Drawing.Point(87, 33);
            this.lbl_nickname.Name = "lbl_nickname";
            this.lbl_nickname.Size = new System.Drawing.Size(76, 16);
            this.lbl_nickname.TabIndex = 3;
            this.lbl_nickname.Text = "黑夜秋日";
            // 
            // tbx_signature
            // 
            this.tbx_signature.BackColor = System.Drawing.SystemColors.Control;
            this.tbx_signature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbx_signature.Location = new System.Drawing.Point(90, 60);
            this.tbx_signature.Multiline = true;
            this.tbx_signature.Name = "tbx_signature";
            this.tbx_signature.ReadOnly = true;
            this.tbx_signature.Size = new System.Drawing.Size(178, 37);
            this.tbx_signature.TabIndex = 4;
            this.tbx_signature.Text = "凡事不要想的太复杂，想多头疼，想通心疼。手不要握的太紧，东西会碎，手会疼。";
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
            this.lsb_friends.Location = new System.Drawing.Point(2, 1);
            this.lsb_friends.Name = "lsb_friends";
            this.lsb_friends.Size = new System.Drawing.Size(276, 445);
            this.lsb_friends.TabIndex = 1;
            this.lsb_friends.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsb_friends_MouseClick);
            this.lsb_friends.DoubleClick += new System.EventHandler(this.lsb_friends_DoubleClick);
            // 
            // cmenus_friend_setting
            // 
            this.cmenus_friend_setting.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmenu_item_send_msg,
            this.tmenu_item_update_note,
            this.tmenu_item_delete_friend});
            this.cmenus_friend_setting.Name = "cmenus_friend_setting";
            this.cmenus_friend_setting.ShowCheckMargin = true;
            this.cmenus_friend_setting.Size = new System.Drawing.Size(171, 70);
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
            // tmenu_item_delete_friend
            // 
            this.tmenu_item_delete_friend.Name = "tmenu_item_delete_friend";
            this.tmenu_item_delete_friend.Size = new System.Drawing.Size(170, 22);
            this.tmenu_item_delete_friend.Text = "删除好友";
            this.tmenu_item_delete_friend.Click += new System.EventHandler(this.tmenu_item_delete_friend_Click);
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
            this.tmenu_update_password,
            this.tmenu_switch_user});
            this.cmenus_setting.Name = "cmenus_setting";
            this.cmenus_setting.Size = new System.Drawing.Size(125, 48);
            // 
            // tmenu_update_password
            // 
            this.tmenu_update_password.Name = "tmenu_update_password";
            this.tmenu_update_password.Size = new System.Drawing.Size(124, 22);
            this.tmenu_update_password.Text = "修改密码";
            this.tmenu_update_password.Click += new System.EventHandler(this.tmenu_update_password_Click);
            // 
            // tmenu_switch_user
            // 
            this.tmenu_switch_user.Name = "tmenu_switch_user";
            this.tmenu_switch_user.Size = new System.Drawing.Size(124, 22);
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
            // picBox_setting
            // 
            this.picBox_setting.ContextMenuStrip = this.cmenus_setting;
            this.picBox_setting.Image = global::SecurityClient.Properties.Resources.setting;
            this.picBox_setting.Location = new System.Drawing.Point(4, 563);
            this.picBox_setting.Name = "picBox_setting";
            this.picBox_setting.Size = new System.Drawing.Size(24, 24);
            this.picBox_setting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_setting.TabIndex = 8;
            this.picBox_setting.TabStop = false;
            // 
            // picBox_user_icon
            // 
            this.picBox_user_icon.Image = global::SecurityClient.Properties.Resources.default_head_pic;
            this.picBox_user_icon.Location = new System.Drawing.Point(17, 33);
            this.picBox_user_icon.Name = "picBox_user_icon";
            this.picBox_user_icon.Size = new System.Drawing.Size(64, 64);
            this.picBox_user_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox_user_icon.TabIndex = 2;
            this.picBox_user_icon.TabStop = false;
            this.picBox_user_icon.Click += new System.EventHandler(this.pbx_user_icon_Click);
            // 
            // ui_main_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 589);
            this.Controls.Add(this.pbx_search_friends);
            this.Controls.Add(this.picBox_setting);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbx_signature);
            this.Controls.Add(this.lbl_nickname);
            this.Controls.Add(this.picBox_user_icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ui_main_panel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "主界面";
            this.Activated += new System.EventHandler(this.ui_main_panel_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ui_main_panel_FormClosing);
            this.Load += new System.EventHandler(this.ui_main_panel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmenus_friend_setting.ResumeLayout(false);
            this.cmenus_setting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_search_friends)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_setting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_user_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_user_icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ContextMenuStrip cmenus_setting;
        private System.Windows.Forms.ToolStripMenuItem tmenu_update_password;
        private System.Windows.Forms.PictureBox picBox_setting;
        private System.Windows.Forms.ToolStripMenuItem tmenu_switch_user;
        private System.Windows.Forms.ContextMenuStrip cmenus_friend_setting;
        private System.Windows.Forms.ToolStripMenuItem tmenu_item_send_msg;
        private System.Windows.Forms.ToolStripMenuItem tmenu_item_update_note;
        private System.Windows.Forms.ToolStripMenuItem tmenu_item_delete_friend;
        private System.Windows.Forms.PictureBox pbx_search_friends;
        public System.Windows.Forms.ListBox lsb_friends;
        public System.Windows.Forms.Label lbl_nickname;
        public System.Windows.Forms.TextBox tbx_signature;
        private System.Windows.Forms.ToolTip tip_main_panel;
    }
}