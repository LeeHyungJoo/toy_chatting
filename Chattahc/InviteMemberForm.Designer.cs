
using System.Windows.Forms;

namespace Chattahc
{
    partial class InviteMemberForm : Form
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.txtbox_invite = new System.Windows.Forms.TextBox();
            this.lb_invite = new System.Windows.Forms.Label();
            this.bt_invite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_invite
            // 
            this.txtbox_invite.Location = new System.Drawing.Point(77, 29);
            this.txtbox_invite.Name = "txtbox_invite";
            this.txtbox_invite.Size = new System.Drawing.Size(127, 21);
            this.txtbox_invite.TabIndex = 0;
            // 
            // lb_invite
            // 
            this.lb_invite.AutoSize = true;
            this.lb_invite.Location = new System.Drawing.Point(25, 32);
            this.lb_invite.Name = "lb_invite";
            this.lb_invite.Size = new System.Drawing.Size(46, 12);
            this.lb_invite.TabIndex = 1;
            this.lb_invite.Text = "Chat ID";
            // 
            // bt_invite
            // 
            this.bt_invite.Location = new System.Drawing.Point(77, 72);
            this.bt_invite.Name = "bt_invite";
            this.bt_invite.Size = new System.Drawing.Size(75, 23);
            this.bt_invite.TabIndex = 2;
            this.bt_invite.Text = "Invite";
            this.bt_invite.UseVisualStyleBackColor = true;
            this.bt_invite.Click += new System.EventHandler(this.member_invite_Click);
            // 
            // InviteMemberForm
            // 
            this.ClientSize = new System.Drawing.Size(240, 107);
            this.Controls.Add(this.bt_invite);
            this.Controls.Add(this.lb_invite);
            this.Controls.Add(this.txtbox_invite);
            this.Name = "InviteMemberForm";
            this.Load += new System.EventHandler(this.InviteMemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtbox_invite;
        private Label lb_invite;
        private Button bt_invite;
    }
}
