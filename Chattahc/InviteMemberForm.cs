using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Chattahc
{
    public partial class InviteMemberForm : Form
    {
        public string ChatIDToInvite { get; private set; }
        public InviteMemberForm()
        {
            InitializeComponent();
        }

        private void InviteMemberForm_Load(object sender, EventArgs e)
        {

        }

        private void member_invite_Click(object sender, EventArgs e)
        {
            ChatIDToInvite = txtbox_invite.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
