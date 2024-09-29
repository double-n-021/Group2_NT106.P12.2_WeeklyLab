namespace Group2_Lab01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai03));
            this.label1 = new System.Windows.Forms.Label();
            this.enterNum = new System.Windows.Forms.TextBox();
            this.btnReadNum = new System.Windows.Forms.Button();
            this.showResults = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số:";
            // 
            // enterNum
            // 
            this.enterNum.Location = new System.Drawing.Point(118, 50);
            this.enterNum.Margin = new System.Windows.Forms.Padding(2);
            this.enterNum.Name = "enterNum";
            this.enterNum.Size = new System.Drawing.Size(299, 20);
            this.enterNum.TabIndex = 1;
            // 
            // btnReadNum
            // 
            this.btnReadNum.BackColor = System.Drawing.Color.Salmon;
            this.btnReadNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReadNum.Location = new System.Drawing.Point(195, 97);
            this.btnReadNum.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadNum.Name = "btnReadNum";
            this.btnReadNum.Size = new System.Drawing.Size(134, 23);
            this.btnReadNum.TabIndex = 2;
            this.btnReadNum.Text = "Đọc số";
            this.btnReadNum.UseVisualStyleBackColor = false;
            this.btnReadNum.Click += new System.EventHandler(this.btnReadNum_Click);
            // 
            // showResults
            // 
            this.showResults.Location = new System.Drawing.Point(134, 149);
            this.showResults.Margin = new System.Windows.Forms.Padding(2);
            this.showResults.Multiline = true;
            this.showResults.Name = "showResults";
            this.showResults.Size = new System.Drawing.Size(264, 34);
            this.showResults.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(424, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(534, 222);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.showResults);
            this.Controls.Add(this.btnReadNum);
            this.Controls.Add(this.enterNum);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Bai03";
            this.Text = "Read Number";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterNum;
        private System.Windows.Forms.Button btnReadNum;
        private System.Windows.Forms.TextBox showResults;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}