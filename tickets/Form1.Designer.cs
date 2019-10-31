namespace tickets
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // LogIn
            // 
            this.LogIn.Location = new System.Drawing.Point(191, 386);
            this.LogIn.Name = "LogIn";
            this.LogIn.Size = new System.Drawing.Size(75, 23);
            this.LogIn.TabIndex = 0;
            this.LogIn.Text = "登录";
            this.LogIn.UseVisualStyleBackColor = true;
            // 
            // SignInMain
            // 
            this.SignInMain.Location = new System.Drawing.Point(643, 379);
            this.SignInMain.Name = "SignInMain";
            this.SignInMain.Size = new System.Drawing.Size(85, 37);
            this.SignInMain.TabIndex = 1;
            this.SignInMain.Text = "注册";
            this.SignInMain.UseVisualStyleBackColor = true;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(310, 120);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(271, 25);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "请输入用户名";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(310, 194);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(267, 25);
            this.Password.TabIndex = 4;
            this.Password.Text = "请输入密码";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 526);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.SignInMain);
            this.Controls.Add(this.LogIn);
            this.Name = "Form1";
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
    }
}