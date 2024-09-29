namespace Group2_Lab01
{
    partial class Bai01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai01));
            this.firstNum = new System.Windows.Forms.Label();
            this.secondNum = new System.Windows.Forms.Label();
            this.thirdNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.disNum1 = new System.Windows.Forms.TextBox();
            this.disNum2 = new System.Windows.Forms.TextBox();
            this.disNum3 = new System.Windows.Forms.TextBox();
            this.biggestNum = new System.Windows.Forms.TextBox();
            this.smallestNum = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNum
            // 
            this.firstNum.AutoSize = true;
            this.firstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNum.ForeColor = System.Drawing.SystemColors.Window;
            this.firstNum.Location = new System.Drawing.Point(16, 50);
            this.firstNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(86, 15);
            this.firstNum.TabIndex = 0;
            this.firstNum.Text = "Số Thứ Nhất";
            // 
            // secondNum
            // 
            this.secondNum.AutoSize = true;
            this.secondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNum.ForeColor = System.Drawing.SystemColors.Window;
            this.secondNum.Location = new System.Drawing.Point(193, 50);
            this.secondNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(78, 15);
            this.secondNum.TabIndex = 1;
            this.secondNum.Text = "Số Thứ Hai";
            // 
            // thirdNum
            // 
            this.thirdNum.AutoSize = true;
            this.thirdNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdNum.ForeColor = System.Drawing.SystemColors.Window;
            this.thirdNum.Location = new System.Drawing.Point(369, 52);
            this.thirdNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.thirdNum.Name = "thirdNum";
            this.thirdNum.Size = new System.Drawing.Size(73, 15);
            this.thirdNum.TabIndex = 2;
            this.thirdNum.Text = "Số Thứ Ba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(55, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lớn Nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(284, 220);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Nhỏ Nhất";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(117, 127);
            this.btnFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(78, 31);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(236, 128);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(354, 128);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // disNum1
            // 
            this.disNum1.BackColor = System.Drawing.SystemColors.Window;
            this.disNum1.Location = new System.Drawing.Point(101, 48);
            this.disNum1.Margin = new System.Windows.Forms.Padding(2);
            this.disNum1.Name = "disNum1";
            this.disNum1.Size = new System.Drawing.Size(76, 20);
            this.disNum1.TabIndex = 8;
            // 
            // disNum2
            // 
            this.disNum2.BackColor = System.Drawing.SystemColors.Window;
            this.disNum2.Location = new System.Drawing.Point(270, 48);
            this.disNum2.Margin = new System.Windows.Forms.Padding(2);
            this.disNum2.Name = "disNum2";
            this.disNum2.Size = new System.Drawing.Size(76, 20);
            this.disNum2.TabIndex = 9;
            // 
            // disNum3
            // 
            this.disNum3.BackColor = System.Drawing.Color.White;
            this.disNum3.Location = new System.Drawing.Point(442, 50);
            this.disNum3.Margin = new System.Windows.Forms.Padding(2);
            this.disNum3.Name = "disNum3";
            this.disNum3.Size = new System.Drawing.Size(76, 20);
            this.disNum3.TabIndex = 10;
            // 
            // biggestNum
            // 
            this.biggestNum.Location = new System.Drawing.Point(158, 220);
            this.biggestNum.Margin = new System.Windows.Forms.Padding(2);
            this.biggestNum.Name = "biggestNum";
            this.biggestNum.ReadOnly = true;
            this.biggestNum.Size = new System.Drawing.Size(76, 20);
            this.biggestNum.TabIndex = 11;
            // 
            // smallestNum
            // 
            this.smallestNum.Location = new System.Drawing.Point(392, 220);
            this.smallestNum.Margin = new System.Windows.Forms.Padding(2);
            this.smallestNum.Name = "smallestNum";
            this.smallestNum.ReadOnly = true;
            this.smallestNum.Size = new System.Drawing.Size(76, 20);
            this.smallestNum.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(463, 116);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(542, 258);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.smallestNum);
            this.Controls.Add(this.biggestNum);
            this.Controls.Add(this.disNum3);
            this.Controls.Add(this.disNum2);
            this.Controls.Add(this.disNum1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thirdNum);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.firstNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Bai01";
            this.Text = "Find Number";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNum;
        private System.Windows.Forms.Label secondNum;
        private System.Windows.Forms.Label thirdNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox disNum1;
        private System.Windows.Forms.TextBox disNum2;
        private System.Windows.Forms.TextBox disNum3;
        private System.Windows.Forms.TextBox biggestNum;
        private System.Windows.Forms.TextBox smallestNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}