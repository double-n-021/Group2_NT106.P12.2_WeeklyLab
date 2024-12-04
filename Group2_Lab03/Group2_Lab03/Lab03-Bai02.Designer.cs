namespace Group2_Lab03
{
    partial class Bai02
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
            this.btListen = new System.Windows.Forms.Button();
            this.lvMessage = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btListen
            // 
            this.btListen.Location = new System.Drawing.Point(313, 12);
            this.btListen.Name = "btListen";
            this.btListen.Size = new System.Drawing.Size(131, 31);
            this.btListen.TabIndex = 11;
            this.btListen.Text = "Listen";
            this.btListen.UseVisualStyleBackColor = true;
            this.btListen.Click += new System.EventHandler(this.btListen_Click);
            // 
            // lvMessage
            // 
            this.lvMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMessage.HideSelection = false;
            this.lvMessage.Location = new System.Drawing.Point(12, 49);
            this.lvMessage.Name = "lvMessage";
            this.lvMessage.Size = new System.Drawing.Size(430, 252);
            this.lvMessage.TabIndex = 12;
            this.lvMessage.UseCompatibleStateImageBehavior = false;
            this.lvMessage.View = System.Windows.Forms.View.List;
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 324);
            this.Controls.Add(this.lvMessage);
            this.Controls.Add(this.btListen);
            this.Name = "Bai02";
            this.Text = "Lab03_Bai02";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btListen;
        private System.Windows.Forms.ListView lvMessage;
    }
}