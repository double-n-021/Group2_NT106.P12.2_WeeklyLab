namespace Group2_Lab03
{
    partial class Bai01_Server
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
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.rtbReceivedMessages = new System.Windows.Forms.RichTextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(52, 18);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(239, 22);
            this.txtPort.TabIndex = 0;
            this.txtPort.Text = "8080";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(13, 21);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(31, 16);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port";
            // 
            // rtbReceivedMessages
            // 
            this.rtbReceivedMessages.Location = new System.Drawing.Point(13, 64);
            this.rtbReceivedMessages.Margin = new System.Windows.Forms.Padding(4);
            this.rtbReceivedMessages.Name = "rtbReceivedMessages";
            this.rtbReceivedMessages.Size = new System.Drawing.Size(482, 221);
            this.rtbReceivedMessages.TabIndex = 2;
            this.rtbReceivedMessages.Text = "";
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(395, 15);
            this.btnListen.Margin = new System.Windows.Forms.Padding(4);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(100, 28);
            this.btnListen.TabIndex = 3;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(13, 44);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(133, 16);
            this.lblMessage.TabIndex = 7;
            this.lblMessage.Text = "Received messages";
            // 
            // Bai01_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 298);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.rtbReceivedMessages);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtPort);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bai01_Server";
            this.Text = "UDP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.RichTextBox rtbReceivedMessages;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.Label lblMessage;
    }
}