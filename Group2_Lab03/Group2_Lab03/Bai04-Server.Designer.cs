namespace Group2_Lab03
{
    partial class Bai04_Server
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
            this.rbtManageMessage = new System.Windows.Forms.RichTextBox();
            this.btnListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtManageMessage
            // 
            this.rbtManageMessage.Location = new System.Drawing.Point(12, 72);
            this.rbtManageMessage.Name = "rbtManageMessage";
            this.rbtManageMessage.Size = new System.Drawing.Size(591, 303);
            this.rbtManageMessage.TabIndex = 0;
            this.rbtManageMessage.Text = "";
            this.rbtManageMessage.TextChanged += new System.EventHandler(this.rbtManageMessage_TextChanged);
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(478, 13);
            this.btnListen.Margin = new System.Windows.Forms.Padding(4);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(125, 41);
            this.btnListen.TabIndex = 4;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // Bai04_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 392);
            this.Controls.Add(this.btnListen);
            this.Controls.Add(this.rbtManageMessage);
            this.Name = "Bai04_Server";
            this.Text = "Bai04_Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rbtManageMessage;
        private System.Windows.Forms.Button btnListen;
    }
}