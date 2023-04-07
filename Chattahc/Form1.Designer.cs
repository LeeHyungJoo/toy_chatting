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
            this.pn_chat = new System.Windows.Forms.Panel();
            this.pn_chatlist = new System.Windows.Forms.Panel();
            this.pn_chatsend = new System.Windows.Forms.Panel();
            this.bt_chatreq = new System.Windows.Forms.Button();
            this.bt_chatsend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lb_chatreq = new System.Windows.Forms.Label();
            this.lb_chat = new System.Windows.Forms.Label();
            this.lb_chatlist = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
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
            this.pn_chatreq.Location = new System.Drawing.Point(7, 5);
            this.pn_chatreq.Name = "pn_chatreq";
            this.pn_chatreq.Size = new System.Drawing.Size(219, 47);
            this.pn_chatreq.TabIndex = 0;
            // 
            // pn_chat
            // 
            this.pn_chat.Controls.Add(this.textBox3);
            this.pn_chat.Controls.Add(this.lb_chat);
            this.pn_chat.Location = new System.Drawing.Point(232, 5);
            this.pn_chat.Name = "pn_chat";
            this.pn_chat.Size = new System.Drawing.Size(312, 486);
            this.pn_chat.TabIndex = 1;
            // 
            // pn_chatlist
            // 
            this.pn_chatlist.Controls.Add(this.button3);
            this.pn_chatlist.Controls.Add(this.lb_chatlist);
            this.pn_chatlist.Location = new System.Drawing.Point(7, 58);
            this.pn_chatlist.Name = "pn_chatlist";
            this.pn_chatlist.Size = new System.Drawing.Size(219, 484);
            this.pn_chatlist.TabIndex = 2;
            // 
            // pn_chatsend
            // 
            this.pn_chatsend.Controls.Add(this.textBox2);
            this.pn_chatsend.Controls.Add(this.bt_chatsend);
            this.pn_chatsend.Location = new System.Drawing.Point(232, 497);
            this.pn_chatsend.Name = "pn_chatsend";
            this.pn_chatsend.Size = new System.Drawing.Size(312, 45);
            this.pn_chatsend.TabIndex = 3;
            // 
            // bt_chatreq
            // 
            this.bt_chatreq.Location = new System.Drawing.Point(166, 20);
            this.bt_chatreq.Name = "bt_chatreq";
            this.bt_chatreq.Size = new System.Drawing.Size(50, 21);
            this.bt_chatreq.TabIndex = 0;
            this.bt_chatreq.Text = "Req";
            this.bt_chatreq.UseVisualStyleBackColor = true;
            this.bt_chatreq.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_chatsend
            // 
            this.bt_chatsend.Location = new System.Drawing.Point(258, 4);
            this.bt_chatsend.Name = "bt_chatsend";
            this.bt_chatsend.Size = new System.Drawing.Size(51, 34);
            this.bt_chatsend.TabIndex = 0;
            this.bt_chatsend.Text = "Send";
            this.bt_chatsend.UseVisualStyleBackColor = true;
            this.bt_chatsend.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 21);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 34);
            this.textBox2.TabIndex = 1;
            // 
            // lb_chatreq
            // 
            this.lb_chatreq.AutoSize = true;
            this.lb_chatreq.Location = new System.Drawing.Point(5, 4);
            this.lb_chatreq.Name = "lb_chatreq";
            this.lb_chatreq.Size = new System.Drawing.Size(81, 12);
            this.lb_chatreq.TabIndex = 0;
            this.lb_chatreq.Text = "Chat Request";
            // 
            // lb_chat
            // 
            this.lb_chat.AutoSize = true;
            this.lb_chat.Location = new System.Drawing.Point(134, 5);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(41, 12);
            this.lb_chat.TabIndex = 0;
            this.lb_chat.Text = "chat_1";
            // 
            // lb_chatlist
            // 
            this.lb_chatlist.AutoSize = true;
            this.lb_chatlist.Location = new System.Drawing.Point(5, 5);
            this.lb_chatlist.Name = "lb_chatlist";
            this.lb_chatlist.Size = new System.Drawing.Size(55, 12);
            this.lb_chatlist.TabIndex = 0;
            this.lb_chatlist.Text = "Chat List";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(5, 20);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(300, 459);
            this.textBox3.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 21);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "chat_1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 554);
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

        }

        #endregion

        private System.Windows.Forms.Panel pn_chatreq;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_chatreq;
        private System.Windows.Forms.Panel pn_chat;
        private System.Windows.Forms.Panel pn_chatlist;
        private System.Windows.Forms.Panel pn_chatsend;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bt_chatsend;
        private System.Windows.Forms.Label lb_chatreq;
        private System.Windows.Forms.Label lb_chat;
        private System.Windows.Forms.Label lb_chatlist;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
    }
}

