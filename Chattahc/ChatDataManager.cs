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

        public string CurrentChatRoomKey { get; set; }
      
        public int RoomCount()
        {
            return chatRoomDict.Count;
        }

        public void Init(string userChatId)
        {
            foreach (var mem in redis.SetMembers(userChatId))
            {
                var roomKey = mem.ToString();
                if (Util.Deserialize<ChatRoom>(redis.StringGet(Util.GenerateChatRoomInfoRedisKey(roomKey))) is ChatRoom chatRoomData)
                {
                    chatRoomDict.Add(roomKey, chatRoomData);
                }
            }
        }


        public void MakeRoom(string roomName)
        {
            var roomKey = $"{roomName}+{Util.GetCurrentTimeStamp()}";

            var roomData = new ChatRoom() { name = roomKey, memberIdSet = new HashSet<string>() { Program.chatId } };
            chatRoomDict.Add(roomKey, roomData);

            redis.StringSet(Util.GenerateChatRoomInfoRedisKey(roomKey), new RedisValue(Util.Serialize(roomData)));
            redis.SetAdd(Program.chatId, new RedisValue(roomKey));
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


        public void InviteToCurrentRoom(string targetChatId)
        {
            if (string.IsNullOrEmpty(CurrentChatRoomKey))
            {
                return;
            }

            if (!chatRoomDict.TryGetValue(CurrentChatRoomKey, out var room))
            {
                return;
            }

            var result = redis.StringGet(Util.GenerateChatIDRedisKey(targetChatId));
            if (result.IsNull)
            {
                return;
            }

            room.memberIdSet.Add(targetChatId);
            redis.SetAdd(targetChatId, new RedisValue(room.name));
        }

        public void SendMessageToRoom(string message)
        {
            string data_str = $"{Program.chatId}+{message}";
            var push = new SortedSetEntry[1] { new SortedSetEntry(new RedisValue(data_str), Util.GetCurrentTimeStamp()) };

            redis.SortedSetAdd(Util.GenerateChatRoomDataRedisKey(CurrentChatRoomKey), push);
        }

        public List<KeyValuePair<string, string>> GetMessageFromCurrentRoom()
        {
            var messageList = new List<KeyValuePair<string, string>>();

            var ret = redis.SortedSetRangeByScore(Util.GenerateChatRoomDataRedisKey(CurrentChatRoomKey));
            ret.ToList().ForEach(item =>
            {
                var str = item.ToString();
                var caret = str.IndexOf('+');
                var sender = str.Substring(0, caret);
                var msg = str.Substring(caret + 1);

                messageList.Add(new KeyValuePair<string, string>(sender, msg));
            });

            return messageList;
        }
    }
}
