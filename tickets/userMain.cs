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
    public partial class userMain : Form
    {
        public userMain()
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

        public string HttpGet(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }

        private void SetJsonToFileList(string jsonContent)
        {
            jsonContent = "{\'Table1\':" + jsonContent + "}";
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(jsonContent);
            DataTable dataTable = dataSet.Tables["Table1"];
            dataTable.Columns.Add("DisplayName", Type.GetType("System.String"));
            dataGridView1.DataSource = dataTable.DefaultView;
        }

        private void SetJsonToFileListBought(string jsonContent)
        {
            jsonContent = "{\'Table1\':" + jsonContent + "}";
            DataSet dataSet = JsonConvert.DeserializeObject<DataSet>(jsonContent);
            DataTable dataTable = dataSet.Tables["Table1"];
            dataTable.Columns.Add("DisplayName", Type.GetType("System.String"));
            dataGridView2.DataSource = dataTable.DefaultView;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Destination_SelectedIndexChanged(object sender, EventArgs e)
        {
            string URL = "http://localhost:8080/applicationServer/Home/Film/GetFilmListByActor/" + Destination.SelectedIndex.ToString();
            string Param = string.Format("");
            string a = HttpGet(URL, Param);
            SetJsonToFileList(a);
        }

        private void userMain_Load(object sender, EventArgs e)
        {
            Form main = new main();
            main.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void returnToMain_Click(object sender, EventArgs e)
        {
            Form main = new main();
            this.Hide();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string departure = Departure.Text;
            string destination = Destination.Text;
            string PostURL = "http://localhost:8080/applicationServer/Home/Actor/NewActor";
            string ParamString = "departure=" + departure + "&&" + "destination=" + destination;
            string result = HttpPost(PostURL, ParamString);
            //MessageBox.Show(result);
        }

        private void Departure_SelectedIndexChanged(object sender, EventArgs e)
        {
            string URL = "http://localhost:8080/applicationServer/Home/Film/GetFilmListByActor/" + Departure.SelectedIndex.ToString();
            string Param = string.Format("");
            string a = HttpGet(URL, Param);
            SetJsonToFileList(a);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string PostURL = "http://localhost:8080/applicationServer/Home/Actor/NewActor";
            string ParamString = "username"+main.thisUserName+"bought";
            string result = HttpPost(PostURL, ParamString);
            SetJsonToFileListBought(result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form changePassword = new changePassword();
            changePassword.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string uniNumber = textBox1.Text;
            string PostURL = "http://localhost:8080/applicationServer/Home/buy/" + uniNumber;
            string ParamString = "username" + main.thisUserName + "bought";
            string result = HttpPost(PostURL, ParamString);
        }
    }
}
