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
            //TODO : 새로운 Dialog 를 통해서, 특정 Id 탐색 후 추가 해야함. 
            //TEST
            chatManager.InviteToCurrentRoom("Yaral");
            chatManager.InviteToCurrentRoom("Yaral2");
            chatManager.InviteToCurrentRoom("Yaral3");
            chatManager.InviteToCurrentRoom("Yaral4");
        }


        private void send_message_Click(object sender, EventArgs e)
        {
            chatManager.SendMessageToRoom(tb_chatsend.Text);
            UpdateChatroomMessage();

        }

        private void UpdateChatroomMessage()
        {
            txtbox_chat.Text = String.Empty;
            foreach (var textitem in chatManager.GetMessageFromCurrentRoom())
            {
                txtbox_chat.Text += ($"[{textitem.Key}] : {textitem.Value}");
                txtbox_chat.Text += "\r\n";
            }
        }
    }
}
