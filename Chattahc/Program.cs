using StackExchange.Redis;
using System;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chattahc
{


    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static ConnectionMultiplexer connection;
        public static string chatId;


        [STAThread]
        static void Main()
        {
            var asr = new AppSettingsReader();
            chatId = asr.GetValue("ID", typeof(string)) as string;

            connection = ConnectionMultiplexer.Connect( asr.GetValue("RedisAddress", typeof(string)) as string);

            //TODO: 처음 입력 시 자동 PW 저장. 그리곤 질의하기. -> RDB로 관리하는게 좋을 것 같다. 
            Console.WriteLine($"redis connected : {connection.IsConnected}");
            var database = connection.GetDatabase();

            var key = Util.GenerateChatIDRedisKey(chatId);
            var result = database.StringGet(key);
            int loginCount = 0;
            if (!result.IsNull)
            {
                loginCount = int.Parse(result.ToString());
            }
            database.StringSet($"{key}", new RedisValue((++loginCount).ToString()));
            //

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ChatForm());
        }
    }
}
