﻿using System.Collections.Generic;

namespace Chattahc
{
    partial class Form1
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
            this.pn_chatreq = new System.Windows.Forms.Panel();
            this.lb_chatreq = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_chatreq = new System.Windows.Forms.Button();
            this.pn_chat = new System.Windows.Forms.Panel();
            this.tb_chat = new System.Windows.Forms.TextBox();
            this.lb_chat = new System.Windows.Forms.Label();
            this.pn_chatlist = new System.Windows.Forms.Panel();
            this.btnTempChat = new System.Windows.Forms.Button();
            this.lb_chatlist = new System.Windows.Forms.Label();
            this.pn_chatsend = new System.Windows.Forms.Panel();
            this.tb_chatsend = new System.Windows.Forms.TextBox();
            this.bt_chatsend = new System.Windows.Forms.Button();
            this.lb_myid = new System.Windows.Forms.Label();
            this.bt_chatrooms = new List<System.Windows.Forms.Button>();

            this.pn_chatreq.SuspendLayout();
            this.pn_chat.SuspendLayout();
            this.pn_chatlist.SuspendLayout();
            this.pn_chatsend.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_chatreq
            // 
            this.pn_chatreq.Controls.Add(this.lb_chatreq);
            this.pn_chatreq.Controls.Add(this.textBox1);
            this.pn_chatreq.Controls.Add(this.bt_chatreq);
            this.pn_chatreq.Location = new System.Drawing.Point(4, 23);
            this.pn_chatreq.Name = "pn_chatreq";
            this.pn_chatreq.Size = new System.Drawing.Size(219, 47);
            this.pn_chatreq.TabIndex = 0;
            // 
            // lb_chatreq
            // 
            this.lb_chatreq.AutoSize = true;
            this.lb_chatreq.Location = new System.Drawing.Point(9, 4);
            this.lb_chatreq.Name = "lb_chatreq";
            this.lb_chatreq.Size = new System.Drawing.Size(81, 12);
            this.lb_chatreq.TabIndex = 0;
            this.lb_chatreq.Text = "Chat Request";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 21);
            this.textBox1.TabIndex = 1;
            // 
            // bt_chatreq
            // 
            this.bt_chatreq.Location = new System.Drawing.Point(166, 20);
            this.bt_chatreq.Name = "bt_chatreq";
            this.bt_chatreq.Size = new System.Drawing.Size(50, 21);
            this.bt_chatreq.TabIndex = 0;
            this.bt_chatreq.Text = "Req";
            this.bt_chatreq.UseVisualStyleBackColor = true;
            this.bt_chatreq.Click += new System.EventHandler(this.bt_chatreq_Click);
            // 
            // pn_chat
            // 
            this.pn_chat.Controls.Add(this.tb_chat);
            this.pn_chat.Controls.Add(this.lb_chat);
            this.pn_chat.Location = new System.Drawing.Point(229, 5);
            this.pn_chat.Name = "pn_chat";
            this.pn_chat.Size = new System.Drawing.Size(312, 504);
            this.pn_chat.TabIndex = 1;
            // 
            // tb_chat
            // 
            this.tb_chat.Location = new System.Drawing.Point(9, 20);
            this.tb_chat.Multiline = true;
            this.tb_chat.Name = "tb_chat";
            this.tb_chat.Size = new System.Drawing.Size(300, 459);
            this.tb_chat.TabIndex = 1;
            // 
            // lb_chat
            // 
            this.lb_chat.AutoSize = true;
            this.lb_chat.Location = new System.Drawing.Point(7, 5);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(40, 12);
            this.lb_chat.TabIndex = 0;
            this.lb_chat.Text = "empty";
            // 
            // pn_chatlist
            // 
            this.pn_chatlist.Controls.Add(this.btnTempChat);
            this.pn_chatlist.Controls.Add(this.lb_chatlist);
            this.pn_chatlist.Location = new System.Drawing.Point(4, 76);
            this.pn_chatlist.Name = "pn_chatlist";
            this.pn_chatlist.Size = new System.Drawing.Size(219, 484);
            this.pn_chatlist.TabIndex = 2;
            // 
            // btnTempChat
            // 
            this.btnTempChat.Location = new System.Drawing.Point(5, 20);
            this.btnTempChat.Name = "btnTempChat";
            this.btnTempChat.Size = new System.Drawing.Size(210, 20);
            this.btnTempChat.TabIndex = 1;
            this.btnTempChat.Text = "Temp_Chat";
            this.btnTempChat.UseVisualStyleBackColor = true;
            this.btnTempChat.UseWaitCursor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 568);
            this.Controls.Add(this.lb_myid);
            this.Controls.Add(this.pn_chatsend);
            this.Controls.Add(this.pn_chatlist);
            this.Controls.Add(this.pn_chat);
            this.Controls.Add(this.pn_chatreq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pn_chatreq.ResumeLayout(false);
            this.pn_chatreq.PerformLayout();
            this.pn_chat.ResumeLayout(false);
            this.pn_chat.PerformLayout();
            this.pn_chatlist.ResumeLayout(false);
            this.pn_chatlist.PerformLayout();
            this.pn_chatsend.ResumeLayout(false);
            this.pn_chatsend.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_chatreq;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_chatreq;
        private System.Windows.Forms.Panel pn_chat;
        private System.Windows.Forms.Panel pn_chatlist;
        private System.Windows.Forms.Panel pn_chatsend;
        private System.Windows.Forms.TextBox tb_chatsend;
        private System.Windows.Forms.Button bt_chatsend;
        private System.Windows.Forms.Label lb_chatreq;
        private System.Windows.Forms.Label lb_chat;
        private System.Windows.Forms.Label lb_chatlist;
        private System.Windows.Forms.TextBox tb_chat;
        private System.Windows.Forms.Button btnTempChat;
        private System.Windows.Forms.Label lb_myid;

        private List<System.Windows.Forms.Button> bt_chatrooms;
    }
}

