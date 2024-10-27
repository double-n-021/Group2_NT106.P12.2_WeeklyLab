namespace Group2_Lab02
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
        /// 

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtLineCount;
        private System.Windows.Forms.TextBox txtWordCount;
        private System.Windows.Forms.TextBox txtCharCount;
        private System.Windows.Forms.RichTextBox rtbContent;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblLineCount;
        private System.Windows.Forms.Label lblWordCount;
        private System.Windows.Forms.Label lblCharCount;

        private void InitializeComponent()
        {
            this.btnExit = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.txtCharCount = new System.Windows.Forms.TextBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblLineCount = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblCharCount = new System.Windows.Forms.Label();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightGreen;
            this.btnExit.Location = new System.Drawing.Point(20, 370);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(260, 35);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(20, 80);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(260, 22);
            this.txtFileName.TabIndex = 4;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(20, 130);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(260, 22);
            this.txtSize.TabIndex = 6;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(20, 180);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(260, 22);
            this.txtURL.TabIndex = 8;
            // 
            // txtLineCount
            // 
            this.txtLineCount.Location = new System.Drawing.Point(20, 230);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.Size = new System.Drawing.Size(260, 22);
            this.txtLineCount.TabIndex = 10;
            // 
            // txtWordCount
            // 
            this.txtWordCount.Location = new System.Drawing.Point(20, 280);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.Size = new System.Drawing.Size(260, 22);
            this.txtWordCount.TabIndex = 12;
            // 
            // txtCharCount
            // 
            this.txtCharCount.Location = new System.Drawing.Point(20, 330);
            this.txtCharCount.Name = "txtCharCount";
            this.txtCharCount.Size = new System.Drawing.Size(260, 22);
            this.txtCharCount.TabIndex = 14;
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(300, 20);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(470, 385);
            this.rtbContent.TabIndex = 15;
            this.rtbContent.Text = "";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.ForeColor = System.Drawing.Color.Blue;
            this.lblFileName.Location = new System.Drawing.Point(20, 60);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(66, 16);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "File name";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.ForeColor = System.Drawing.Color.Blue;
            this.lblSize.Location = new System.Drawing.Point(20, 110);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(33, 16);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.ForeColor = System.Drawing.Color.Blue;
            this.lblURL.Location = new System.Drawing.Point(20, 160);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(34, 16);
            this.lblURL.TabIndex = 7;
            this.lblURL.Text = "URL";
            // 
            // lblLineCount
            // 
            this.lblLineCount.AutoSize = true;
            this.lblLineCount.ForeColor = System.Drawing.Color.Blue;
            this.lblLineCount.Location = new System.Drawing.Point(20, 210);
            this.lblLineCount.Name = "lblLineCount";
            this.lblLineCount.Size = new System.Drawing.Size(67, 16);
            this.lblLineCount.TabIndex = 9;
            this.lblLineCount.Text = "Line count";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.ForeColor = System.Drawing.Color.Blue;
            this.lblWordCount.Location = new System.Drawing.Point(20, 260);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(82, 16);
            this.lblWordCount.TabIndex = 11;
            this.lblWordCount.Text = "Words count";
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCharCount.Location = new System.Drawing.Point(20, 310);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(100, 16);
            this.lblCharCount.TabIndex = 13;
            this.lblCharCount.Text = "Character count";
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(20, 20);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(260, 37);
            this.btnReadFile.TabIndex = 16;
            this.btnReadFile.Text = "Read from File ";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 423);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.rtbContent);
            this.Controls.Add(this.txtCharCount);
            this.Controls.Add(this.lblCharCount);
            this.Controls.Add(this.txtWordCount);
            this.Controls.Add(this.lblWordCount);
            this.Controls.Add(this.txtLineCount);
            this.Controls.Add(this.lblLineCount);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnExit);
            this.Name = "Bai02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab02_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
    }
}