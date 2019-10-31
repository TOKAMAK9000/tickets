using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace tickets
{
    public partial class addTrain : Form
    {
        public addTrain()
        {
            InitializeComponent();
            this.ControlBox = false;

        }
        private string HttpPost(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = Encoding.UTF8.GetByteCount(postDataStr);
            Stream myRequestStream = request.GetRequestStream();
            StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.GetEncoding("gb2312"));
            myStreamWriter.Write(postDataStr);
            myStreamWriter.Close();

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uniNumber = textBox1.Text;
            string departure = comboBox1.Text;
            string destanation = comboBox2.Text;
            string startTime = textBox2.Text;
            string arriveTime = textBox3.Text;
            string trainNumber = textBox4.Text;

            string PostURL = "http://localhost:8080/applicationServer/Home/Actor/NewActor";
            string ParamString = "uniNumber=" + uniNumber + "&&" + "departure=" + departure + "&&" + "destanation=" + destanation + "&&" + "startTime=" + startTime + "&&" + "arriveTime=" + arriveTime + "&&" + "trainNumber=" + trainNumber;
            string result = HttpPost(PostURL, ParamString);

            //TODO：判断返回值，若正确直接退出窗口

        }
    }
}
