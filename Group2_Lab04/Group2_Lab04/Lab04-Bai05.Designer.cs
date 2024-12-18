namespace Group2_Lab04
{
    partial class Lab04_Bai05
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
            this.tbLink = new System.Windows.Forms.TextBox();
            this.btnGET = new System.Windows.Forms.Button();
            this.LbURL = new System.Windows.Forms.Label();
            this.rtbDisplayInfo = new System.Windows.Forms.RichTextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(91, 17);
            this.tbLink.Multiline = true;
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(320, 26);
            this.tbLink.TabIndex = 0;
            // 
            // btnGET
            // 
            this.btnGET.Location = new System.Drawing.Point(436, 17);
            this.btnGET.Name = "btnGET";
            this.btnGET.Size = new System.Drawing.Size(158, 26);
            this.btnGET.TabIndex = 3;
            this.btnGET.Text = "GET";
            this.btnGET.UseVisualStyleBackColor = true;
            this.btnGET.Click += new System.EventHandler(this.btnGET_Click);
            // 
            // LbURL
            // 
            this.LbURL.AutoSize = true;
            this.LbURL.Location = new System.Drawing.Point(12, 27);
            this.LbURL.Name = "LbURL";
            this.LbURL.Size = new System.Drawing.Size(34, 16);
            this.LbURL.TabIndex = 4;
            this.LbURL.Text = "URL";
            // 
            // rtbDisplayInfo
            // 
            this.rtbDisplayInfo.Location = new System.Drawing.Point(15, 149);
            this.rtbDisplayInfo.Name = "rtbDisplayInfo";
            this.rtbDisplayInfo.Size = new System.Drawing.Size(579, 232);
            this.rtbDisplayInfo.TabIndex = 7;
            this.rtbDisplayInfo.Text = "";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(12, 105);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 16);
            this.lbPassword.TabIndex = 12;
            this.lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(12, 64);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 16);
            this.lbUsername.TabIndex = 11;
            this.lbUsername.Text = "Username";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(436, 61);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(158, 70);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(91, 105);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(320, 26);
            this.tbPassword.TabIndex = 9;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(91, 61);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(320, 26);
            this.tbUsername.TabIndex = 8;
            // 
            // HTTP_GET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 396);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.rtbDisplayInfo);
            this.Controls.Add(this.LbURL);
            this.Controls.Add(this.btnGET);
            this.Controls.Add(this.tbLink);
            this.Name = "Lab04_Bai05";
            this.Text = "HTTP GET";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Button btnGET;
        private System.Windows.Forms.Label LbURL;
        private System.Windows.Forms.RichTextBox rtbDisplayInfo;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
    }
}