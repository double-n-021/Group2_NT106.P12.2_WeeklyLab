namespace Group2_Lab04
{
    partial class Lab04_Bai02
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.rtbDisplayInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(12, 12);
            this.tbLink.Multiline = true;
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(431, 37);
            this.tbLink.TabIndex = 0;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(449, 12);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(97, 80);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(12, 55);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(431, 37);
            this.tbAddress.TabIndex = 2;
            // 
            // rtbDisplayInfo
            // 
            this.rtbDisplayInfo.Location = new System.Drawing.Point(12, 108);
            this.rtbDisplayInfo.Name = "rtbDisplayInfo";
            this.rtbDisplayInfo.Size = new System.Drawing.Size(534, 329);
            this.rtbDisplayInfo.TabIndex = 3;
            this.rtbDisplayInfo.Text = "";
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 461);
            this.Controls.Add(this.rtbDisplayInfo);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.tbLink);
            this.Name = "Lab04_Bai02";
            this.Text = "Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.RichTextBox rtbDisplayInfo;
    }
}