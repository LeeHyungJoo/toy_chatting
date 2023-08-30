using System.Collections.Generic;

namespace Chattahc
{
    partial class ChatForm
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
            this.pn_chatreq = new System.Windows.Forms.Panel();
            this.lb_makeroom = new System.Windows.Forms.Label();
            this.txtbox_makeroom = new System.Windows.Forms.TextBox();
            this.bt_makeroom = new System.Windows.Forms.Button();
            this.pn_chat = new System.Windows.Forms.Panel();
            this.txtbox_chat = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.stripmenu_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.stripmenu_setting_maxmembers = new System.Windows.Forms.ToolStripMenuItem();
            this.stripmenu_invite = new System.Windows.Forms.ToolStripMenuItem();
            this.stripmenu_member_invite = new System.Windows.Forms.ToolStripMenuItem();
            this.stripmenu_member_ban = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_chat = new System.Windows.Forms.Label();
            this.pn_chatlist = new System.Windows.Forms.Panel();
            this.flp_chatlist = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_chatlist = new System.Windows.Forms.Label();
            this.pn_chatsend = new System.Windows.Forms.Panel();
            this.tb_chatsend = new System.Windows.Forms.TextBox();
            this.bt_chatsend = new System.Windows.Forms.Button();
            this.lb_myid = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pn_chatreq.SuspendLayout();
            this.pn_chat.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pn_chatlist.SuspendLayout();
            this.pn_chatsend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_chatreq
            // 
            this.pn_chatreq.Controls.Add(this.lb_makeroom);
            this.pn_chatreq.Controls.Add(this.txtbox_makeroom);
            this.pn_chatreq.Controls.Add(this.bt_makeroom);
            this.pn_chatreq.Location = new System.Drawing.Point(4, 23);
            this.pn_chatreq.Name = "pn_chatreq";
            this.pn_chatreq.Size = new System.Drawing.Size(219, 47);
            this.pn_chatreq.TabIndex = 0;
            // 
            // lb_makeroom
            // 
            this.lb_makeroom.AutoSize = true;
            this.lb_makeroom.Location = new System.Drawing.Point(9, 4);
            this.lb_makeroom.Name = "lb_makeroom";
            this.lb_makeroom.Size = new System.Drawing.Size(69, 12);
            this.lb_makeroom.TabIndex = 0;
            this.lb_makeroom.Text = "MakeRoom";
            // 
            // txtbox_makeroom
            // 
            this.txtbox_makeroom.Location = new System.Drawing.Point(9, 20);
            this.txtbox_makeroom.Name = "txtbox_makeroom";
            this.txtbox_makeroom.Size = new System.Drawing.Size(156, 21);
            this.txtbox_makeroom.TabIndex = 1;
            // 
            // bt_makeroom
            // 
            this.bt_makeroom.Location = new System.Drawing.Point(166, 20);
            this.bt_makeroom.Name = "bt_makeroom";
            this.bt_makeroom.Size = new System.Drawing.Size(50, 21);
            this.bt_makeroom.TabIndex = 0;
            this.bt_makeroom.Text = "Req";
            this.bt_makeroom.UseVisualStyleBackColor = true;
            this.bt_makeroom.Click += new System.EventHandler(this.bt_makeroom_Click);
            // 
            // pn_chat
            // 
            this.pn_chat.Controls.Add(this.txtbox_chat);
            this.pn_chat.Controls.Add(this.menuStrip1);
            this.pn_chat.Location = new System.Drawing.Point(229, 27);
            this.pn_chat.Name = "pn_chat";
            this.pn_chat.Size = new System.Drawing.Size(312, 482);
            this.pn_chat.TabIndex = 1;
            // 
            // txtbox_chat
            // 
            this.txtbox_chat.Enabled = false;
            this.txtbox_chat.Location = new System.Drawing.Point(9, 27);
            this.txtbox_chat.Multiline = true;
            this.txtbox_chat.Name = "txtbox_chat";
            this.txtbox_chat.ReadOnly = true;
            this.txtbox_chat.Size = new System.Drawing.Size(300, 474);
            this.txtbox_chat.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripmenu_setting,
            this.stripmenu_invite});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(312, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // stripmenu_setting
            // 
            this.stripmenu_setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripmenu_setting_maxmembers});
            this.stripmenu_setting.Name = "stripmenu_setting";
            this.stripmenu_setting.Size = new System.Drawing.Size(57, 20);
            this.stripmenu_setting.Text = "Setting";
            // 
            // stripmenu_setting_maxmembers
            // 
            this.stripmenu_setting_maxmembers.Name = "stripmenu_setting_maxmembers";
            this.stripmenu_setting_maxmembers.Size = new System.Drawing.Size(166, 22);
            this.stripmenu_setting_maxmembers.Text = "Max Memebers...";
            // 
            // stripmenu_invite
            // 
            this.stripmenu_invite.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripmenu_member_invite,
            this.stripmenu_member_ban});
            this.stripmenu_invite.Name = "stripmenu_invite";
            this.stripmenu_invite.Size = new System.Drawing.Size(64, 20);
            this.stripmenu_invite.Text = "Member";
            // 
            // stripmenu_member_invite
            // 
            this.stripmenu_member_invite.Name = "stripmenu_member_invite";
            this.stripmenu_member_invite.Size = new System.Drawing.Size(109, 22);
            this.stripmenu_member_invite.Text = "Invite..";
            this.stripmenu_member_invite.Click += new System.EventHandler(this.stripmenu_member_invite_Click);
            // 
            // stripmenu_member_ban
            // 
            this.stripmenu_member_ban.Name = "stripmenu_member_ban";
            this.stripmenu_member_ban.Size = new System.Drawing.Size(109, 22);
            this.stripmenu_member_ban.Text = "Ban...";
            // 
            // lb_chat
            // 
            this.lb_chat.AutoSize = true;
            this.lb_chat.Location = new System.Drawing.Point(236, 5);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(68, 12);
            this.lb_chat.TabIndex = 0;
            this.lb_chat.Text = "Chat Room";
            // 
            // pn_chatlist
            // 
            this.pn_chatlist.Controls.Add(this.flp_chatlist);
            this.pn_chatlist.Controls.Add(this.lb_chatlist);
            this.pn_chatlist.Location = new System.Drawing.Point(4, 76);
            this.pn_chatlist.Name = "pn_chatlist";
            this.pn_chatlist.Size = new System.Drawing.Size(219, 484);
            this.pn_chatlist.TabIndex = 2;
            // 
            // flp_chatlist
            // 
            this.flp_chatlist.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_chatlist.Location = new System.Drawing.Point(9, 21);
            this.flp_chatlist.Name = "flp_chatlist";
            this.flp_chatlist.Size = new System.Drawing.Size(200, 456);
            this.flp_chatlist.TabIndex = 1;
            // 
            // lb_chatlist
            // 
            this.lb_chatlist.AutoSize = true;
            this.lb_chatlist.Location = new System.Drawing.Point(9, 5);
            this.lb_chatlist.Name = "lb_chatlist";
            this.lb_chatlist.Size = new System.Drawing.Size(55, 12);
            this.lb_chatlist.TabIndex = 0;
            this.lb_chatlist.Text = "Chat List";
            // 
            // pn_chatsend
            // 
            this.pn_chatsend.Controls.Add(this.tb_chatsend);
            this.pn_chatsend.Controls.Add(this.bt_chatsend);
            this.pn_chatsend.Location = new System.Drawing.Point(229, 515);
            this.pn_chatsend.Name = "pn_chatsend";
            this.pn_chatsend.Size = new System.Drawing.Size(312, 45);
            this.pn_chatsend.TabIndex = 3;
            // 
            // tb_chatsend
            // 
            this.tb_chatsend.Location = new System.Drawing.Point(9, 4);
            this.tb_chatsend.Multiline = true;
            this.tb_chatsend.Name = "tb_chatsend";
            this.tb_chatsend.Size = new System.Drawing.Size(249, 34);
            this.tb_chatsend.TabIndex = 1;
            // 
            // bt_chatsend
            // 
            this.bt_chatsend.Location = new System.Drawing.Point(262, 4);
            this.bt_chatsend.Name = "bt_chatsend";
            this.bt_chatsend.Size = new System.Drawing.Size(51, 34);
            this.bt_chatsend.TabIndex = 0;
            this.bt_chatsend.Text = "Send";
            this.bt_chatsend.UseVisualStyleBackColor = true;
            this.bt_chatsend.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_myid
            // 
            this.lb_myid.AutoSize = true;
            this.lb_myid.Location = new System.Drawing.Point(4, 5);
            this.lb_myid.Name = "lb_myid";
            this.lb_myid.Size = new System.Drawing.Size(39, 12);
            this.lb_myid.TabIndex = 4;
            this.lb_myid.Text = "MY ID";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 568);
            this.Controls.Add(this.lb_chat);
            this.Controls.Add(this.lb_myid);
            this.Controls.Add(this.pn_chatsend);
            this.Controls.Add(this.pn_chatlist);
            this.Controls.Add(this.pn_chat);
            this.Controls.Add(this.pn_chatreq);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ChatForm";
            this.Text = "Form1";
            this.pn_chatreq.ResumeLayout(false);
            this.pn_chatreq.PerformLayout();
            this.pn_chat.ResumeLayout(false);
            this.pn_chat.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pn_chatlist.ResumeLayout(false);
            this.pn_chatlist.PerformLayout();
            this.pn_chatsend.ResumeLayout(false);
            this.pn_chatsend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_chatreq;
        private System.Windows.Forms.TextBox txtbox_makeroom;
        private System.Windows.Forms.Button bt_makeroom;
        private System.Windows.Forms.Panel pn_chat;
        private System.Windows.Forms.Panel pn_chatlist;
        private System.Windows.Forms.Panel pn_chatsend;
        private System.Windows.Forms.TextBox tb_chatsend;
        private System.Windows.Forms.Button bt_chatsend;
        private System.Windows.Forms.Label lb_makeroom;
        private System.Windows.Forms.Label lb_chat;
        private System.Windows.Forms.Label lb_chatlist;
        private System.Windows.Forms.TextBox txtbox_chat;
        private System.Windows.Forms.Label lb_myid;

        private Dictionary<string, System.Windows.Forms.Button> chatRoomBtnDict = new Dictionary<string, System.Windows.Forms.Button>();
        private System.Windows.Forms.FlowLayoutPanel flp_chatlist;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_setting;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_setting_maxmembers;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_invite;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_member_ban;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_member_invite;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

