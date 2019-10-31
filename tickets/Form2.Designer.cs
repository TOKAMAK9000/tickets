namespace tickets
{
    partial class Form2
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
            this.SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewUsername
            // 
            this.NewUsername.Location = new System.Drawing.Point(239, 46);
            this.NewUsername.Name = "NewUsername";
            this.NewUsername.Size = new System.Drawing.Size(285, 25);
            this.NewUsername.TabIndex = 0;
            this.NewUsername.Text = "请输入用户名";
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(238, 111);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(285, 25);
            this.NewPassword.TabIndex = 1;
            this.NewPassword.Text = "请输入密码";
            // 
            // UserID
            // 
            this.UserID.Location = new System.Drawing.Point(239, 181);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(284, 25);
            this.UserID.TabIndex = 2;
            this.UserID.Text = "请输入身份证号码";
            // 
            // RealName
            // 
            this.RealName.Location = new System.Drawing.Point(237, 248);
            this.RealName.Name = "RealName";
            this.RealName.Size = new System.Drawing.Size(286, 25);
            this.RealName.TabIndex = 3;
            this.RealName.Text = "请输入真实姓名";
            // 
            // SignIn
            // 
            this.SignIn.Location = new System.Drawing.Point(266, 326);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(147, 27);
            this.SignIn.TabIndex = 4;
            this.SignIn.Text = "注册";
            this.SignIn.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.RealName);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.NewUsername);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
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
    }
}