using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using StackExchange.Redis;

namespace Chattahc
{
    public static class Util
    {
        public static long GetTimeStampMS() => DateTime.UtcNow.Ticks;

        public static object Deserialize<T>(string s) where T : struct
        {
            using (var stream = new MemoryStream(Convert.FromBase64String(s)))
            {
                return (T)(new BinaryFormatter()).Deserialize(stream);
            }
        }

        public static string Serialize<T>(T data) where T : struct
        {
            using (var stream = new MemoryStream())
            {
                (new BinaryFormatter()).Serialize(stream, data);
                return Convert.ToBase64String(stream.ToArray());
            }
        }

        public static RedisKey GenerateChatRoomRedisKey(string roomKey) => new RedisKey("CHATROOM:" + roomKey);
    }
}
