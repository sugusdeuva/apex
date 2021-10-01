using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ReproductorMultimedia
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string command, StringBuilder returnValue, int returnLength, IntPtr winHandle);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = "mi_tension.mp3";
            string mediaName = "MP3";
            string playCommand;



            playCommand = "Open \"" + fileName + "\" type mpegvideo alias " + mediaName;
            mciSendString(playCommand, null, 0, IntPtr.Zero);

            playCommand = "Play " + mediaName;
            mciSendString(playCommand, null, 0, IntPtr.Zero);
        }
    }
}
