namespace Group2_Lab05
{
    partial class Lab05_Bai02
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvDisplayEmail = new System.Windows.Forms.ListView();
            this.nmrRecent = new System.Windows.Forms.NumericUpDown();
            this.nmrTotal = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrRecent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(671, 28);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 61);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Lavender;
            this.txtEmail.Location = new System.Drawing.Point(129, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(326, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Lavender;
            this.txtPassword.Location = new System.Drawing.Point(129, 67);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(326, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Recent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            // 
            // lvDisplayEmail
            // 
            this.lvDisplayEmail.BackColor = System.Drawing.Color.LightBlue;
            this.lvDisplayEmail.HideSelection = false;
            this.lvDisplayEmail.Location = new System.Drawing.Point(12, 116);
            this.lvDisplayEmail.Name = "lvDisplayEmail";
            this.lvDisplayEmail.Size = new System.Drawing.Size(816, 271);
            this.lvDisplayEmail.TabIndex = 9;
            this.lvDisplayEmail.UseCompatibleStateImageBehavior = false;
            // 
            // nmrRecent
            // 
            this.nmrRecent.BackColor = System.Drawing.Color.Lavender;
            this.nmrRecent.Location = new System.Drawing.Point(554, 67);
            this.nmrRecent.Name = "nmrRecent";
            this.nmrRecent.Size = new System.Drawing.Size(94, 22);
            this.nmrRecent.TabIndex = 10;
            // 
            // nmrTotal
            // 
            this.nmrTotal.BackColor = System.Drawing.Color.Lavender;
            this.nmrTotal.Location = new System.Drawing.Point(554, 29);
            this.nmrTotal.Name = "nmrTotal";
            this.nmrTotal.Size = new System.Drawing.Size(94, 22);
            this.nmrTotal.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email:";
            // 
            // Lab05_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Group2_Lab05.Properties.Resources.Jujutsu_Kaisen_HD_Wallpaper_and_Background;
            this.ClientSize = new System.Drawing.Size(841, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nmrTotal);
            this.Controls.Add(this.nmrRecent);
            this.Controls.Add(this.lvDisplayEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnLogin);
            this.Name = "Lab05_Bai02";
            this.Text = "Read Mail - IMAP";
            ((System.ComponentModel.ISupportInitialize)(this.nmrRecent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvDisplayEmail;
        private System.Windows.Forms.NumericUpDown nmrRecent;
        private System.Windows.Forms.NumericUpDown nmrTotal;
        private System.Windows.Forms.Label label3;

    }
}