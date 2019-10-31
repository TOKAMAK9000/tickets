namespace tickets
{
    partial class signIn
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
            this.NewUsername = new System.Windows.Forms.TextBox();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.UserID = new System.Windows.Forms.TextBox();
            this.RealName = new System.Windows.Forms.TextBox();
            this.regist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewUsername
            // 
            this.NewUsername.Location = new System.Drawing.Point(179, 37);
            this.NewUsername.Margin = new System.Windows.Forms.Padding(2);
            this.NewUsername.Name = "NewUsername";
            this.NewUsername.Size = new System.Drawing.Size(215, 21);
            this.NewUsername.TabIndex = 0;
            this.NewUsername.Text = "请输入用户名";
            this.NewUsername.Click += new System.EventHandler(this.NewUsername_Click);
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(178, 89);
            this.NewPassword.Margin = new System.Windows.Forms.Padding(2);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(215, 21);
            this.NewPassword.TabIndex = 1;
            this.NewPassword.Text = "请输入密码";
            this.NewPassword.Click += new System.EventHandler(this.NewPassword_Click);
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(179, 145);
            this.UserID.Margin = new System.Windows.Forms.Padding(2);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(214, 21);
            this.UserID.TabIndex = 2;
            this.UserID.Text = "请输入身份证号码";
            this.UserID.Click += new System.EventHandler(this.UserID_Click);
            // 
            // RealName
            // 
            this.RealName.Location = new System.Drawing.Point(178, 198);
            this.RealName.Margin = new System.Windows.Forms.Padding(2);
            this.RealName.Name = "RealName";
            this.RealName.Size = new System.Drawing.Size(216, 21);
            this.RealName.TabIndex = 3;
            this.RealName.Text = "请输入真实姓名";
            this.RealName.Click += new System.EventHandler(this.RealName_Click);
            this.RealName.TextChanged += new System.EventHandler(this.RealName_TextChanged);
            // 
            // regist
            // 
            this.regist.Location = new System.Drawing.Point(236, 259);
            this.regist.Name = "regist";
            this.regist.Size = new System.Drawing.Size(75, 23);
            this.regist.TabIndex = 4;
            this.regist.Text = "注册";
            this.regist.UseVisualStyleBackColor = true;
            this.regist.Click += new System.EventHandler(this.regist_Click);
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.regist);
            this.Controls.Add(this.RealName);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.NewUsername);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "signIn";
            this.Text = "新用户注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewUsername;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox UserID;
        private System.Windows.Forms.TextBox RealName;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button regist;
    }
}