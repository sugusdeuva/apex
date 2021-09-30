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
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dateTime;
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

            pictureBox1.Image = Image.FromFile("iconos/" + json["daily"]["data"][0]["icon"].ToString() + ".png");
            pictureBox2.Image = Image.FromFile("iconos/" + json["daily"]["data"][1]["icon"].ToString() + ".png");
            pictureBox3.Image = Image.FromFile("iconos/" + json["daily"]["data"][2]["icon"].ToString() + ".png");
            pictureBox4.Image = Image.FromFile("iconos/" + json["daily"]["data"][3]["icon"].ToString() + ".png");
            pictureBox5.Image = Image.FromFile("iconos/" + json["daily"]["data"][4]["icon"].ToString() + ".png");
            pictureBox6.Image = Image.FromFile("iconos/" + json["daily"]["data"][5]["icon"].ToString() + ".png");
            pictureBox7.Image = Image.FromFile("iconos/" + json["daily"]["data"][6]["icon"].ToString() + ".png");
            pictureBox8.Image = Image.FromFile("iconos/" + json["daily"]["data"][7]["icon"].ToString() + ".png");

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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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

            pictureBox1.Image = Image.FromFile("iconos/" + json["daily"]["data"][0]["icon"].ToString() + ".png");
            pictureBox2.Image = Image.FromFile("iconos/" + json["daily"]["data"][1]["icon"].ToString() + ".png");
            pictureBox3.Image = Image.FromFile("iconos/" + json["daily"]["data"][2]["icon"].ToString() + ".png");
            pictureBox4.Image = Image.FromFile("iconos/" + json["daily"]["data"][3]["icon"].ToString() + ".png");
            pictureBox5.Image = Image.FromFile("iconos/" + json["daily"]["data"][4]["icon"].ToString() + ".png");
            pictureBox6.Image = Image.FromFile("iconos/" + json["daily"]["data"][5]["icon"].ToString() + ".png");
            pictureBox7.Image = Image.FromFile("iconos/" + json["daily"]["data"][6]["icon"].ToString() + ".png");
            pictureBox8.Image = Image.FromFile("iconos/" + json["daily"]["data"][7]["icon"].ToString() + ".png");
            
            DateTime d = UnixTimeStampToDateTime(Convert.ToDouble(json["currently"]["time"]));
            string s = d.ToLongDateString();
           
            /*MessageBox.Show(json["daily"]["data"][0]["icon"] + ".jpg");
            MessageBox.Show(json["daily"]["data"][1]["icon"] + ".jpg");
            MessageBox.Show(json["daily"]["data"][2]["icon"] + ".jpg");
            */
            Console.ReadLine();
        }
       
        
    }
}
