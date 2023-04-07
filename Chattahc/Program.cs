using StackExchange.Redis;
using System;
using System.Collections.Generic;
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


        public static ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("127.0.0.1:6379");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
