namespace Group2_Lab04
{
    partial class Lab04_Bai01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab04_Bai01));
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.btGet = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbShow
            // 
            this.rtbShow.BackColor = System.Drawing.Color.LightGray;
            this.rtbShow.Location = new System.Drawing.Point(13, 47);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.ReadOnly = true;
            this.rtbShow.Size = new System.Drawing.Size(709, 363);
            this.rtbShow.TabIndex = 5;
            this.rtbShow.Text = "";
            // 
            // btGet
            // 
            this.btGet.Location = new System.Drawing.Point(625, 16);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(97, 28);
            this.btGet.TabIndex = 4;
            this.btGet.Text = "GET";
            this.btGet.UseVisualStyleBackColor = true;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // tbURL
            // 
            this.tbURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbURL.Location = new System.Drawing.Point(13, 19);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(595, 22);
            this.tbURL.TabIndex = 3;
            // 
            // Lab04_Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(734, 426);
            this.Controls.Add(this.rtbShow);
            this.Controls.Add(this.btGet);
            this.Controls.Add(this.tbURL);
            this.Name = "Lab04_Bai01";
            this.Text = "Lab04_Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.TextBox tbURL;
    }
}