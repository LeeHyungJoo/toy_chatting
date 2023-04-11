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
    public partial class Form1 : Form
    {
        public ConnectionMultiplexer redis = Program.redis;

        public Form1()
        {
            InitializeComponent();
            lb_myid.Text = Program.chat_id + " - Chatting room";
        }

        private void bt_chatreq_Click(object sender, EventArgs e)
        {
            /*
             * 1. 해당 chat id 로 등록된 채팅이 있는지 확인. (대화 내용)
             * 2. 있으면 등록. 없으면 그냥 가져오면 되고. 
             * 3. 등록할 때는, srcID + room id , destID + room id 둘다 등록 (대화 목록)
             * 4. 실제 대화는 대화 내용 쪽에만 저장. 
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bt_chatroom_Click(string chatRoomName)
        {
            lb_chat.Text = btnTempChat.Text;
        }
    }
}
