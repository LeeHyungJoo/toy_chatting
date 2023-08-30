using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chattahc
{
    public class ChatDataManager
    {
        public IDatabase redis = Program.connection.GetDatabase();
        public Dictionary<string, ChatRoom> chatRoomDict = new Dictionary<string, ChatRoom>();

        public string CurrentChatRoomKey { get; private set; }

        public int RoomCount()
        {
            return chatRoomDict.Count;
        }

        public void Init(string userChatId)
        {
            var binSerializer = new BinaryFormatter();
            foreach (var mem in redis.SetMembers(userChatId))
            {
                var roomKey = mem.ToString();
                var roomData = Util.Deserialize<ChatRoom>(redis.StringGet(Util.GenerateChatRoomRedisKey(roomKey)));

                if (roomData is ChatRoom chatRoomData)
                {
                    chatRoomDict.Add(roomKey, chatRoomData);
                }
                else
                {
                    Console.WriteLine("Parsing Failed");
                }

            }
        }


        public void MakeRoom(string roomName)
        {
            var roomKey = roomName + "+" + Util.GetTimeStampMS().ToString();

            var roomData = new ChatRoom() { name = roomKey, memberIdList = new List<string>() { Program.chat_id } };
            chatRoomDict.Add(roomKey, roomData);

            redis.StringSet(Util.GenerateChatRoomRedisKey(roomKey), new RedisValue(Util.Serialize(roomData)));
            redis.SetAdd(Program.chat_id, new RedisValue(roomKey));
        }

        public List<Button> GetToAddChatRoomBtns(List<string> btnRoomkeyList, EventHandler btnEventHandler)
        {
            var toAddBtnList = new List<Button>();
            foreach (var room in chatRoomDict.AsQueryable().Where(t => !btnRoomkeyList.Any(s => s == t.Key)))
            {
                var roomKey = room.Value.name;
                var roomName = roomKey.Substring(0, roomKey.LastIndexOf('+'));

                var btn = new Button()
                {
                    Name = room.Key,
                    Text = roomName,
                    Visible = true,
                    Width = 180,
                };

                btn.Click += btnEventHandler;
                toAddBtnList.Add(btn);
            }

            return toAddBtnList;
        }


    }


}
