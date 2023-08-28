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
using StackExchange.Redis;

namespace Chattahc
{
    [Serializable]
    public struct ChatRoom
    {
        public string name;
    }


    public partial class ChatForm : Form
    {
        public IDatabase redis = Program.connection.GetDatabase();
        public Dictionary<string, ChatRoom> chatRoomDict = new Dictionary<string, ChatRoom>();
        public string currentChatRoomName;
        public Timer timer = new Timer();

        public ChatForm()
        {
            InitializeComponent();
            lb_myid.Text = Program.chat_id + " - Chatting room";

            foreach (var mem in redis.SetMembers(Program.chat_id))
            {
                var key = mem.ToString();
                var idx = key.LastIndexOf('+');

                chatRoomDict.Add(key, new ChatRoom() { name = key.Substring(0, idx) });
            }

            timer.Interval = 250;
            timer.Tick += Update;
            timer.Start();
        }

        public void Update(object sender, EventArgs e)
        {
            if (chatRoomDict.Count != chatRoomBtnDict.Count)
            {
                var toAddRooms = chatRoomDict.AsQueryable().Where(t => !chatRoomBtnDict.ContainsKey(t.Key));
                var btns = new List<Button>();
                foreach (var room in toAddRooms)
                {
                    btns.Add(new Button()
                    {
                        Name = room.Key,
                        Text = room.Value.name,
                        Visible = true
                    });

                    btns.Last().Click += new EventHandler(bt_chatroom_Click);
                    chatRoomBtnDict.Add(room.Key, btns.Last());
                }

                flp_chatlist.Controls.AddRange(btns.ToArray());
            }

        }

        private void bt_makeroom_Click(object sender, EventArgs e)
        {
            if (txtbox_makeroom.Text == string.Empty)
                return;

            var roomName = txtbox_makeroom.Text;
            var roomKey = roomName + "+" + Util.GetTimeStampMS().ToString();
            var roomNameKey = new RedisKey("CHATROOM:" + roomKey);

            redis.StringSet(roomNameKey, new RedisValue("-"));
            chatRoomDict.Add(roomKey, new ChatRoom() { name = roomName });

            redis.SetAdd(Program.chat_id, new RedisValue(roomKey));
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bt_chatroom_Click(object sender, EventArgs e)
        {
            if (sender is Button chatBtn)
            {
                //주고받은 대화 가져오기. 
            }
        }
    }
}
