using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;

namespace ServicioClima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string sURL;
            WebRequest wrGETURL;
            JObject json;
            Stream objStream;

            sURL = "https://api.darksky.net/forecast/b4497c8a6b18bf75776b7fd997f2b90a/-34.6119666,-58.4030375?lang=es&units=ca";
            wrGETURL = WebRequest.Create(sURL);
            objStream = wrGETURL.GetResponse().GetResponseStream();
            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            string sLinePrev = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLinePrev = sLine;
                sLine = objReader.ReadLine();
                //if (sLine != null)
                //    MessageBox.Show(sLine);                    

            }
            //MessageBox.Show(sLinePrev);

            json = JObject.Parse(sLinePrev);

            MessageBox.Show(json["daily"]["data"][0]["icon"] + ".jpg");
            MessageBox.Show(json["daily"]["data"][1]["icon"] + ".jpg");
            MessageBox.Show(json["daily"]["data"][2]["icon"] + ".jpg");

            Console.ReadLine();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
