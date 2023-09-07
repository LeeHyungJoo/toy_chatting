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
            this.lb_makeRoom = new System.Windows.Forms.Label();
            this.txtb_roomName = new System.Windows.Forms.TextBox();
            this.bt_makeRoom = new System.Windows.Forms.Button();
            this.pn_chat = new System.Windows.Forms.Panel();
            this.txtb_chatContents = new System.Windows.Forms.TextBox();
            this.stripmenu_chatRoom = new System.Windows.Forms.MenuStrip();
            this.stripmenu_chatRoom_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.stripmenu_setting_maxmembers = new System.Windows.Forms.ToolStripMenuItem();
            this.stripmenu_member = new System.Windows.Forms.ToolStripMenuItem();
            this.stripmenu_member_invite = new System.Windows.Forms.ToolStripMenuItem();
            this.stripmenu_member_ban = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_chatRoom = new System.Windows.Forms.Label();
            this.pn_chatList = new System.Windows.Forms.Panel();
            this.flpn_chatList = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_chatList = new System.Windows.Forms.Label();
            this.pn_chatsend = new System.Windows.Forms.Panel();
            this.tb_chatsend = new System.Windows.Forms.TextBox();
            this.bt_chatsend = new System.Windows.Forms.Button();
            this.lb_myId = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pn_chatreq.SuspendLayout();
            this.pn_chat.SuspendLayout();
            this.stripmenu_chatRoom.SuspendLayout();
            this.pn_chatList.SuspendLayout();
            this.pn_chatsend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_chatreq
            // 
            this.pn_chatreq.Controls.Add(this.lb_makeRoom);
            this.pn_chatreq.Controls.Add(this.txtb_roomName);
            this.pn_chatreq.Controls.Add(this.bt_makeRoom);
            this.pn_chatreq.Location = new System.Drawing.Point(4, 23);
            this.pn_chatreq.Name = "pn_chatreq";
            this.pn_chatreq.Size = new System.Drawing.Size(219, 47);
            this.pn_chatreq.TabIndex = 0;
            // 
            // lb_makeRoom
            // 
            this.lb_makeRoom.AutoSize = true;
            this.lb_makeRoom.Location = new System.Drawing.Point(9, 4);
            this.lb_makeRoom.Name = "lb_makeRoom";
            this.lb_makeRoom.Size = new System.Drawing.Size(69, 12);
            this.lb_makeRoom.TabIndex = 0;
            this.lb_makeRoom.Text = "MakeRoom";
            // 
            // txtb_roomName
            // 
            this.txtb_roomName.Location = new System.Drawing.Point(9, 20);
            this.txtb_roomName.Name = "txtb_roomName";
            this.txtb_roomName.Size = new System.Drawing.Size(156, 21);
            this.txtb_roomName.TabIndex = 1;
            this.txtb_roomName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_makeroom_keydown_Click);
            // 
            // bt_makeRoom
            // 
            this.bt_makeRoom.Location = new System.Drawing.Point(166, 20);
            this.bt_makeRoom.Name = "bt_makeRoom";
            this.bt_makeRoom.Size = new System.Drawing.Size(50, 21);
            this.bt_makeRoom.TabIndex = 0;
            this.bt_makeRoom.Text = "Req";
            this.bt_makeRoom.UseVisualStyleBackColor = true;
            this.bt_makeRoom.Click += new System.EventHandler(this.bt_makeroom_Click);
            // 
            // pn_chat
            // 
            this.pn_chat.Controls.Add(this.txtb_chatContents);
            this.pn_chat.Controls.Add(this.stripmenu_chatRoom);
            this.pn_chat.Location = new System.Drawing.Point(229, 27);
            this.pn_chat.Name = "pn_chat";
            this.pn_chat.Size = new System.Drawing.Size(312, 482);
            this.pn_chat.TabIndex = 1;
            // 
            // txtb_chatContents
            // 
            this.txtb_chatContents.Enabled = false;
            this.txtb_chatContents.Location = new System.Drawing.Point(9, 27);
            this.txtb_chatContents.Multiline = true;
            this.txtb_chatContents.Name = "txtb_chatContents";
            this.txtb_chatContents.ReadOnly = true;
            this.txtb_chatContents.Size = new System.Drawing.Size(300, 474);
            this.txtb_chatContents.TabIndex = 1;
            // 
            // stripmenu_chatRoom
            // 
            this.stripmenu_chatRoom.GripMargin = new System.Windows.Forms.Padding(2);
            this.stripmenu_chatRoom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripmenu_chatRoom_setting,
            this.stripmenu_member});
            this.stripmenu_chatRoom.Location = new System.Drawing.Point(0, 0);
            this.stripmenu_chatRoom.Name = "stripmenu_chatRoom";
            this.stripmenu_chatRoom.Size = new System.Drawing.Size(312, 24);
            this.stripmenu_chatRoom.TabIndex = 2;
            this.stripmenu_chatRoom.Text = "menuStrip1";
            // 
            // stripmenu_chatRoom_setting
            // 
            this.stripmenu_chatRoom_setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripmenu_setting_maxmembers});
            this.stripmenu_chatRoom_setting.Name = "stripmenu_chatRoom_setting";
            this.stripmenu_chatRoom_setting.Size = new System.Drawing.Size(57, 20);
            this.stripmenu_chatRoom_setting.Text = "Setting";
            // 
            // stripmenu_setting_maxmembers
            // 
            this.stripmenu_setting_maxmembers.Name = "stripmenu_setting_maxmembers";
            this.stripmenu_setting_maxmembers.Size = new System.Drawing.Size(180, 22);
            this.stripmenu_setting_maxmembers.Text = "Max Memebers...";
            // 
            // stripmenu_member
            // 
            this.stripmenu_member.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripmenu_member_invite,
            this.stripmenu_member_ban});
            this.stripmenu_member.Name = "stripmenu_member";
            this.stripmenu_member.Size = new System.Drawing.Size(64, 20);
            this.stripmenu_member.Text = "Member";
            // 
            // stripmenu_member_invite
            // 
            this.stripmenu_member_invite.Name = "stripmenu_member_invite";
            this.stripmenu_member_invite.Size = new System.Drawing.Size(180, 22);
            this.stripmenu_member_invite.Text = "Invite..";
            this.stripmenu_member_invite.Click += new System.EventHandler(this.stripmenu_member_invite_Click);
            // 
            // stripmenu_member_ban
            // 
            this.stripmenu_member_ban.Name = "stripmenu_member_ban";
            this.stripmenu_member_ban.Size = new System.Drawing.Size(180, 22);
            this.stripmenu_member_ban.Text = "Ban...";
            // 
            // lb_chatRoom
            // 
            this.lb_chatRoom.AutoSize = true;
            this.lb_chatRoom.Location = new System.Drawing.Point(236, 5);
            this.lb_chatRoom.Name = "lb_chatRoom";
            this.lb_chatRoom.Size = new System.Drawing.Size(68, 12);
            this.lb_chatRoom.TabIndex = 0;
            this.lb_chatRoom.Text = "Chat Room";
            // 
            // pn_chatList
            // 
            this.pn_chatList.Controls.Add(this.flpn_chatList);
            this.pn_chatList.Controls.Add(this.lb_chatList);
            this.pn_chatList.Location = new System.Drawing.Point(4, 76);
            this.pn_chatList.Name = "pn_chatList";
            this.pn_chatList.Size = new System.Drawing.Size(219, 484);
            this.pn_chatList.TabIndex = 2;
            // 
            // flpn_chatList
            // 
            this.flpn_chatList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpn_chatList.Location = new System.Drawing.Point(9, 21);
            this.flpn_chatList.Name = "flpn_chatList";
            this.flpn_chatList.Size = new System.Drawing.Size(200, 456);
            this.flpn_chatList.TabIndex = 1;
            // 
            // lb_chatList
            // 
            this.lb_chatList.AutoSize = true;
            this.lb_chatList.Location = new System.Drawing.Point(9, 5);
            this.lb_chatList.Name = "lb_chatList";
            this.lb_chatList.Size = new System.Drawing.Size(55, 12);
            this.lb_chatList.TabIndex = 0;
            this.lb_chatList.Text = "Chat List";
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
            this.tb_chatsend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_chatsend_keydown_Click);
            this.tb_chatsend.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ignore_enter_Click);
            // 
            // bt_chatsend
            // 
            this.bt_chatsend.Location = new System.Drawing.Point(261, 4);
            this.bt_chatsend.Name = "bt_chatsend";
            this.bt_chatsend.Size = new System.Drawing.Size(51, 34);
            this.bt_chatsend.TabIndex = 0;
            this.bt_chatsend.Text = "Send";
            this.bt_chatsend.UseVisualStyleBackColor = true;
            this.bt_chatsend.Click += new System.EventHandler(this.send_message_Click);
            // 
            // lb_myId
            // 
            this.lb_myId.AutoSize = true;
            this.lb_myId.Location = new System.Drawing.Point(4, 5);
            this.lb_myId.Name = "lb_myId";
            this.lb_myId.Size = new System.Drawing.Size(39, 12);
            this.lb_myId.TabIndex = 4;
            this.lb_myId.Text = "MY ID";
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
            this.Controls.Add(this.lb_chatRoom);
            this.Controls.Add(this.lb_myId);
            this.Controls.Add(this.pn_chatsend);
            this.Controls.Add(this.pn_chatList);
            this.Controls.Add(this.pn_chat);
            this.Controls.Add(this.pn_chatreq);
            this.MainMenuStrip = this.stripmenu_chatRoom;
            this.Name = "ChatForm";
            this.Text = "Form1";
            this.pn_chatreq.ResumeLayout(false);
            this.pn_chatreq.PerformLayout();
            this.pn_chat.ResumeLayout(false);
            this.pn_chat.PerformLayout();
            this.stripmenu_chatRoom.ResumeLayout(false);
            this.stripmenu_chatRoom.PerformLayout();
            this.pn_chatList.ResumeLayout(false);
            this.pn_chatList.PerformLayout();
            this.pn_chatsend.ResumeLayout(false);
            this.pn_chatsend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_chatreq;
        private System.Windows.Forms.TextBox txtb_roomName;
        private System.Windows.Forms.Button bt_makeRoom;
        private System.Windows.Forms.Panel pn_chat;
        private System.Windows.Forms.Panel pn_chatList;
        private System.Windows.Forms.Panel pn_chatsend;
        private System.Windows.Forms.TextBox tb_chatsend;
        private System.Windows.Forms.Button bt_chatsend;
        private System.Windows.Forms.Label lb_makeRoom;
        private System.Windows.Forms.Label lb_chatRoom;
        private System.Windows.Forms.Label lb_chatList;
        private System.Windows.Forms.TextBox txtb_chatContents;
        private System.Windows.Forms.Label lb_myId;

        private Dictionary<string, System.Windows.Forms.Button> chatRoomBtnDict = new Dictionary<string, System.Windows.Forms.Button>();
        private System.Windows.Forms.FlowLayoutPanel flpn_chatList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip stripmenu_chatRoom;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_chatRoom_setting;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_setting_maxmembers;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_member;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_member_ban;
        private System.Windows.Forms.ToolStripMenuItem stripmenu_member_invite;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

