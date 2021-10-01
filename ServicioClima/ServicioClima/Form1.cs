using Newtonsoft.Json.Linq;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

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

            sURL = "https://api.darksky.net/forecast/b4497c8a6b18bf75776b7fd997f2b90a/-34.6128452,-58.4078885?lang=es&units=ca";
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

            label33.Text = "" + json["currently"]["summary"].ToString();

            label8.Text = "C° " + json["currently"]["temperature"].ToString();

            label5.Text = "C° " + json["daily"]["data"][0]["temperatureHigh"].ToString();
            label7.Text = "C° " + json["daily"]["data"][0]["temperatureLow"].ToString();
            label20.Text = "C° " + json["daily"]["data"][1]["temperatureHigh"].ToString();
            label19.Text = "C° " + json["daily"]["data"][1]["temperatureLow"].ToString();
            label21.Text = "C° " + json["daily"]["data"][2]["temperatureHigh"].ToString();
            label22.Text = "C° " + json["daily"]["data"][2]["temperatureLow"].ToString();
            label23.Text = "C° " + json["daily"]["data"][3]["temperatureHigh"].ToString();
            label24.Text = "C° " + json["daily"]["data"][3]["temperatureLow"].ToString();
            label25.Text = "C° " + json["daily"]["data"][4]["temperatureHigh"].ToString();
            label26.Text = "C° " + json["daily"]["data"][4]["temperatureLow"].ToString();
            label27.Text = "C° " + json["daily"]["data"][5]["temperatureHigh"].ToString();
            label28.Text = "C° " + json["daily"]["data"][5]["temperatureLow"].ToString();
            label29.Text = "C° " + json["daily"]["data"][6]["temperatureHigh"].ToString();
            label30.Text = "C° " + json["daily"]["data"][6]["temperatureLow"].ToString();
            label31.Text = "C° " + json["daily"]["data"][7]["temperatureHigh"].ToString();
            label32.Text = "C° " + json["daily"]["data"][7]["temperatureLow"].ToString();
            Console.ReadLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label3.Text = DateTime.Now.ToString("dddd, dd MMMM HH:mm:ss");
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("dddd, dd MMMM HH:mm:ss");
            timer1.Start();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
