namespace Group2_Lab03
{
    partial class Bai03_Client
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
            this.rtbMessage = new System.Windows.Forms.RichTextBox();
            this.btConnect = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(12, 38);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.Size = new System.Drawing.Size(532, 114);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(551, 38);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(153, 34);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(550, 78);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(153, 34);
            this.btSend.TabIndex = 2;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(550, 118);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(153, 34);
            this.btDisconnect.TabIndex = 3;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // Bai03_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 172);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.rtbMessage);
            this.Name = "Bai03_Client";
            this.Text = "Client";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btDisconnect;
    }
}