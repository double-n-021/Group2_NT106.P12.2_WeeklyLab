namespace Group2_Lab03
{
    partial class Bai04_Client
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
            this.lvParticipants = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbYourName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btSendFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbYourFriendName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // rtbMessage
            // 
            this.rtbMessage.Location = new System.Drawing.Point(12, 12);
            this.rtbMessage.Name = "rtbMessage";
            this.rtbMessage.ReadOnly = true;
            this.rtbMessage.Size = new System.Drawing.Size(631, 214);
            this.rtbMessage.TabIndex = 0;
            this.rtbMessage.Text = "";
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(151, 251);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(132, 31);
            this.btConnect.TabIndex = 1;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lvParticipants
            // 
            this.lvParticipants.HideSelection = false;
            this.lvParticipants.Location = new System.Drawing.Point(653, 31);
            this.lvParticipants.Name = "lvParticipants";
            this.lvParticipants.Size = new System.Drawing.Size(142, 315);
            this.lvParticipants.TabIndex = 2;
            this.lvParticipants.UseCompatibleStateImageBehavior = false;
            this.lvParticipants.View = System.Windows.Forms.View.List;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Participants";
            // 
            // tbYourName
            // 
            this.tbYourName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbYourName.Location = new System.Drawing.Point(13, 255);
            this.tbYourName.Name = "tbYourName";
            this.tbYourName.Size = new System.Drawing.Size(132, 22);
            this.tbYourName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Message";
            // 
            // tbMessage
            // 
            this.tbMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMessage.Location = new System.Drawing.Point(15, 324);
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(490, 22);
            this.tbMessage.TabIndex = 7;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(511, 319);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(132, 31);
            this.btSend.TabIndex = 6;
            this.btSend.Text = "Send";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btSendFile
            // 
            this.btSendFile.Location = new System.Drawing.Point(511, 282);
            this.btSendFile.Name = "btSendFile";
            this.btSendFile.Size = new System.Drawing.Size(132, 31);
            this.btSendFile.TabIndex = 9;
            this.btSendFile.Text = "Send File";
            this.btSendFile.UseVisualStyleBackColor = true;
            this.btSendFile.Click += new System.EventHandler(this.btSendFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Friend";
            // 
            // tbYourFriendName
            // 
            this.tbYourFriendName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbYourFriendName.Location = new System.Drawing.Point(373, 287);
            this.tbYourFriendName.Name = "tbYourFriendName";
            this.tbYourFriendName.Size = new System.Drawing.Size(132, 22);
            this.tbYourFriendName.TabIndex = 10;
            // 
            // Bai04_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbYourFriendName);
            this.Controls.Add(this.btSendFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbYourName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvParticipants);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.rtbMessage);
            this.Name = "Bai04_Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbMessage;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ListView lvParticipants;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbYourName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btSendFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbYourFriendName;
    }
}