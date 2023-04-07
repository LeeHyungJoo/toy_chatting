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
        public Form1()
        {
            InitializeComponent();
            AppSettingsReader asr = new AppSettingsReader();
            lb_myid.Text = asr.GetValue("ID", typeof(string)) as String;
            lb_myid.Text += " - Chatting room";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
