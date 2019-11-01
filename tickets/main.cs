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
    public partial class main : Form
    {
        public static string thisUserName = "";
        public main()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SignInMain_Click(object sender, EventArgs e)
        {
            Form signInMain = new signIn();
            Form main = new main();
            signInMain.Show();
            main.Hide();

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string userName = UserName.Text;
            string password = Password.Text;
            string PostURL = "http://localhost:8080/tickets/Home/User/login";
            string ParamString = "userName=" + userName + "&&" + "password=" + password;
            string result = HttpGet(PostURL, ParamString);
            if (result == "success")
            {
                MessageBox.Show("pong!");
            }
            Form userMain = new userMain();
            this.Hide();
            userMain.Show();
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
