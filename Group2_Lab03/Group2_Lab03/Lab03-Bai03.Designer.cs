namespace Group2_Lab03
{
    partial class Bai03
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
            this.btOpenServer = new System.Windows.Forms.Button();
            this.btOpenClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btOpenServer
            // 
            this.btOpenServer.Location = new System.Drawing.Point(23, 12);
            this.btOpenServer.Name = "btOpenServer";
            this.btOpenServer.Size = new System.Drawing.Size(431, 34);
            this.btOpenServer.TabIndex = 0;
            this.btOpenServer.Text = "Open TCP Server";
            this.btOpenServer.UseVisualStyleBackColor = true;
            this.btOpenServer.Click += new System.EventHandler(this.btOpenServer_Click);
            // 
            // btOpenClient
            // 
            this.btOpenClient.Location = new System.Drawing.Point(22, 62);
            this.btOpenClient.Name = "btOpenClient";
            this.btOpenClient.Size = new System.Drawing.Size(431, 34);
            this.btOpenClient.TabIndex = 1;
            this.btOpenClient.Text = "Open new TCP Client";
            this.btOpenClient.UseVisualStyleBackColor = true;
            this.btOpenClient.Click += new System.EventHandler(this.btOpenClient_Click);
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 114);
            this.Controls.Add(this.btOpenClient);
            this.Controls.Add(this.btOpenServer);
            this.Name = "Bai03";
            this.Text = "Lab03_Bai03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOpenServer;
        private System.Windows.Forms.Button btOpenClient;
    }
}