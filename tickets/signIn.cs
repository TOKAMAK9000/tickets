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
    public partial class signIn : Form
    {
        public signIn()
        {
            InitializeComponent();
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

        private void RealName_TextChanged(object sender, EventArgs e)
        {

        }

        private void regist_Click(object sender, EventArgs e)
        {
            string RUsername = NewUsername.Text;
            string RPassword = NewPassword.Text;
            string RUserID = UserID.Text;
            string RRealName = RealName.Text;

            if (RUserID.Length!=18)
            {
                MessageBox.Show("您的身份证号长度不合法");
                UserID.Text = "";
                return;
            }
            if (RPassword.Length < 6)
            {
                MessageBox.Show("您的密码长度过短，请重新输入");
                NewPassword.Text = "";
                return;
            }
            string newUsername = NewUsername.Text;
            string newPassword = NewPassword.Text;
            string userID = UserID.Text;
            string realName = RealName.Text;
            string PostURL = "http://localhost:8080/applicationServer/Home/Actor/NewActor";
            string ParamString = "newUsername=" + newUsername + "&&" + "newPassword=" + newPassword + "&&" + "userID=" + userID + "&&" + "realName=" + realName;
            string result = HttpPost(PostURL, ParamString);
            Form Main = new main();
            this.Hide();
            Main.Show();
        }

        private void NewUsername_Click(object sender, EventArgs e)
        {
            NewUsername.Text = "";
        }

        private void NewPassword_Click(object sender, EventArgs e)
        {
            NewPassword.Text = "";
        }

        private void UserID_Click(object sender, EventArgs e)
        {
            UserID.Text = "";
        }

        private void RealName_Click(object sender, EventArgs e)
        {
            RealName.Text = "";
        }
    }
}
