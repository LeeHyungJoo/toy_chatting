using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chattahc
{
    [Serializable]
    struct ChatRoom
    {
        public int room_id;
    }

    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");
        public static string chat_id = string.Empty;
        public static List<ChatRoom> chatroom_list = new List<ChatRoom>();
        

        [STAThread]
        static void Main()
        {
            AppSettingsReader asr = new AppSettingsReader();
            chat_id = asr.GetValue("ID", typeof(string)) as string;

            //TODO: 처음 입력 시 자동 PW 저장. 그리곤 질의하기. -> RDB로 관리하는게 좋을 것 같다. 

            var database = redis.GetDatabase();
            database.SetAdd("CHATID::" + chat_id, "0000");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
