using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using StackExchange.Redis;

namespace Chattahc
{
    public partial class ChatForm : Form
    {
        public Timer timer = new Timer();
        public ChatDataManager chatManager = new ChatDataManager();

        public ChatForm()
        {
            InitializeComponent();
            lb_myid.Text = Program.chatId + " - Chatting room";

            timer.Interval = 250;
            timer.Tick += Update;
            timer.Start();

            chatManager.Init(Program.chatId);
        }

        public bool CheckRoomListUpdate()
        {
            return chatManager.RoomCount() != chatRoomBtnDict.Count;
        }

        public bool ChatContextEnabled()
        {
            return !string.IsNullOrEmpty(chatManager.CurrentChatRoomKey);
        }

        public void Update(object sender, EventArgs e)
        {
            if (CheckRoomListUpdate())
            {
                var toAddBtnList = chatManager.GetToAddChatRoomBtns(chatRoomBtnDict.Keys.ToList(), new EventHandler(bt_chatroom_Click));

                foreach (var btn in toAddBtnList)
                {
                    chatRoomBtnDict.Add(btn.Name, btn);
                }

                flp_chatlist.Controls.AddRange(toAddBtnList.ToArray());
            }

            txtbox_chat.Enabled = ChatContextEnabled();
        }

        private void bt_makeroom_Click(object sender, EventArgs e)
        {
            if (txtbox_makeroom.Text == string.Empty)
                return;

            chatManager.MakeRoom(txtbox_makeroom.Text);
            txtbox_makeroom.ResetText();
        }

        private void bt_chatroom_Click(object sender, EventArgs e)
        {
            if (sender is Button chatBtn)
            {
                chatManager.CurrentChatRoomKey = chatBtn.Name;
                UpdateChatroomMessage();
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Program.connection.Close();
        }

        private void stripmenu_member_invite_Click(object sender, EventArgs e)
        {
            using (var secondForm = new InviteMemberForm())
            {
                DialogResult result = secondForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    chatManager.InviteToCurrentRoom(secondForm.ChatIDToInvite);
                }
            }
        }


        private void send_message_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(chatManager.CurrentChatRoomKey))
                return;

            chatManager.SendMessageToRoom(tb_chatsend.Text);
            UpdateChatroomMessage();
            tb_chatsend.ResetText();
        }

        private void UpdateChatroomMessage()
        {
            if (string.IsNullOrEmpty(chatManager.CurrentChatRoomKey))
                return;

            txtbox_chat.ResetText();
            foreach (var textitem in chatManager.GetMessageFromCurrentRoom())
            {
                txtbox_chat.Text += ($"[{textitem.Key}] : {textitem.Value}");
                txtbox_chat.Text += "\r\n";
            }
        }
        private void ignore_enter_Click(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void tb_chatsend_keydown_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (e.Modifiers == Keys.Shift)
                {
                    tb_chatsend.SelectedText += "\r\n";
                }
                else
                {
                    send_message_Click(sender, new EventArgs());
                }
                e.Handled = true;
            }
        }

        private void tb_makeroom_keydown_Click(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_makeroom_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
