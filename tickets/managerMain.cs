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
    public partial class managerMain : Form
    {
        public managerMain()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            string URL = "http://localhost:8080/applicationServer/Home/getAllUser/";
            string Param = string.Format("");
            string a = HttpGet(URL, Param);
            SetJsonToFileList(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string URL = "http://localhost:8080/applicationServer/Home/getUniNumber/";
            string Param = string.Format("");
            string a = HttpGet(URL, Param);
            SetJsonToFileList(a);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form main = new main();
            this.Hide();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form addTrain = new addTrain();
            addTrain.Show();
        }
    }
}
