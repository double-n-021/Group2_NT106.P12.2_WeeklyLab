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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai02));
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
            this.btnExit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(40, 717);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(520, 68);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(40, 155);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(516, 38);
            this.txtFileName.TabIndex = 4;
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(40, 252);
            this.txtSize.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(516, 38);
            this.txtSize.TabIndex = 6;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(40, 349);
            this.txtURL.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(516, 38);
            this.txtURL.TabIndex = 8;
            // 
            // txtLineCount
            // 
            this.txtLineCount.Location = new System.Drawing.Point(40, 446);
            this.txtLineCount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtLineCount.Name = "txtLineCount";
            this.txtLineCount.Size = new System.Drawing.Size(516, 38);
            this.txtLineCount.TabIndex = 10;
            // 
            // txtWordCount
            // 
            this.txtWordCount.Location = new System.Drawing.Point(40, 542);
            this.txtWordCount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtWordCount.Name = "txtWordCount";
            this.txtWordCount.Size = new System.Drawing.Size(516, 38);
            this.txtWordCount.TabIndex = 12;
            // 
            // txtCharCount
            // 
            this.txtCharCount.Location = new System.Drawing.Point(40, 639);
            this.txtCharCount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCharCount.Name = "txtCharCount";
            this.txtCharCount.Size = new System.Drawing.Size(516, 38);
            this.txtCharCount.TabIndex = 14;
            // 
            // rtbContent
            // 
            this.rtbContent.Location = new System.Drawing.Point(600, 39);
            this.rtbContent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.Size = new System.Drawing.Size(936, 742);
            this.rtbContent.TabIndex = 15;
            this.rtbContent.Text = "";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.Blue;
            this.lblFileName.Location = new System.Drawing.Point(40, 116);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(148, 32);
            this.lblFileName.TabIndex = 3;
            this.lblFileName.Text = "File name";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.Blue;
            this.lblSize.Location = new System.Drawing.Point(40, 213);
            this.lblSize.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(74, 32);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURL.ForeColor = System.Drawing.Color.Blue;
            this.lblURL.Location = new System.Drawing.Point(40, 310);
            this.lblURL.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(73, 32);
            this.lblURL.TabIndex = 7;
            this.lblURL.Text = "URL";
            // 
            // lblLineCount
            // 
            this.lblLineCount.AutoSize = true;
            this.lblLineCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineCount.ForeColor = System.Drawing.Color.Blue;
            this.lblLineCount.Location = new System.Drawing.Point(40, 407);
            this.lblLineCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLineCount.Name = "lblLineCount";
            this.lblLineCount.Size = new System.Drawing.Size(156, 32);
            this.lblLineCount.TabIndex = 9;
            this.lblLineCount.Text = "Line count";
            // 
            // lblWordCount
            // 
            this.lblWordCount.AutoSize = true;
            this.lblWordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWordCount.ForeColor = System.Drawing.Color.Blue;
            this.lblWordCount.Location = new System.Drawing.Point(40, 504);
            this.lblWordCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(183, 32);
            this.lblWordCount.TabIndex = 11;
            this.lblWordCount.Text = "Words count";
            // 
            // lblCharCount
            // 
            this.lblCharCount.AutoSize = true;
            this.lblCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCharCount.Location = new System.Drawing.Point(40, 601);
            this.lblCharCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCharCount.Name = "lblCharCount";
            this.lblCharCount.Size = new System.Drawing.Size(230, 32);
            this.lblCharCount.TabIndex = 13;
            this.lblCharCount.Text = "Character count";
            // 
            // btnReadFile
            // 
            this.btnReadFile.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadFile.Location = new System.Drawing.Point(40, 39);
            this.btnReadFile.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(520, 72);
            this.btnReadFile.TabIndex = 16;
            this.btnReadFile.Text = "Read from File ";
            this.btnReadFile.UseVisualStyleBackColor = false;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1564, 820);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "Bai02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 02 Read From File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
    }
}