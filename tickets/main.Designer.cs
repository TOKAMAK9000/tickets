namespace tickets
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LogIn = new System.Windows.Forms.Button();
            this.SignInMain = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(294, 205);
            this.LogIn.Margin = new System.Windows.Forms.Padding(2);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(64, 30);
            this.LogIn.TabIndex = 0;
            this.LogIn.Text = "登录";
            this.LogIn.UseVisualStyleBackColor = true;
            this.LogIn.Click += new System.EventHandler(this.LogIn_Click);
            // 
            // SignInMain
            // 
            this.SignInMain.Location = new System.Drawing.Point(294, 262);
            this.SignInMain.Margin = new System.Windows.Forms.Padding(2);
            this.SignInMain.Name = "SignInMain";
            this.SignInMain.Size = new System.Drawing.Size(64, 30);
            this.SignInMain.TabIndex = 1;
            this.SignInMain.Text = "注册";
            this.SignInMain.UseVisualStyleBackColor = true;
            this.SignInMain.Click += new System.EventHandler(this.SignInMain_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(232, 96);
            this.UserName.Margin = new System.Windows.Forms.Padding(2);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(204, 21);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "请输入用户名";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(232, 155);
            this.Password.Margin = new System.Windows.Forms.Padding(2);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(201, 21);
            this.Password.TabIndex = 4;
            this.Password.Text = "请输入密码";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "退出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.SignInMain);
            this.Controls.Add(this.LogIn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main";
            this.Text = "购票系统登入页面";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogIn;
        private System.Windows.Forms.Button SignInMain;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button1;
    }
}