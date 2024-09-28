namespace Largest_Smallest_Number
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // firstNum
            // 
            this.firstNum.AutoSize = true;
            this.firstNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNum.ForeColor = System.Drawing.SystemColors.Window;
            this.firstNum.Location = new System.Drawing.Point(22, 62);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(102, 18);
            this.firstNum.TabIndex = 0;
            this.firstNum.Text = "Số Thứ Nhất";
            // 
            // secondNum
            // 
            this.secondNum.AutoSize = true;
            this.secondNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondNum.ForeColor = System.Drawing.SystemColors.Window;
            this.secondNum.Location = new System.Drawing.Point(257, 62);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(92, 18);
            this.secondNum.TabIndex = 1;
            this.secondNum.Text = "Số Thứ Hai";
            // 
            // thirdNum
            // 
            this.thirdNum.AutoSize = true;
            this.thirdNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdNum.ForeColor = System.Drawing.SystemColors.Window;
            this.thirdNum.Location = new System.Drawing.Point(492, 64);
            this.thirdNum.Name = "thirdNum";
            this.thirdNum.Size = new System.Drawing.Size(87, 18);
            this.thirdNum.TabIndex = 2;
            this.thirdNum.Text = "Số Thứ Ba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(73, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lớn Nhất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(379, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Nhỏ Nhất";
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(156, 158);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(104, 38);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(314, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 37);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(472, 158);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 37);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // disNum1
            // 
            this.disNum1.BackColor = System.Drawing.SystemColors.Window;
            this.disNum1.Location = new System.Drawing.Point(135, 59);
            this.disNum1.Name = "disNum1";
            this.disNum1.Size = new System.Drawing.Size(100, 22);
            this.disNum1.TabIndex = 8;
            // 
            // disNum2
            // 
            this.disNum2.BackColor = System.Drawing.SystemColors.Window;
            this.disNum2.Location = new System.Drawing.Point(360, 59);
            this.disNum2.Name = "disNum2";
            this.disNum2.Size = new System.Drawing.Size(100, 22);
            this.disNum2.TabIndex = 9;
            // 
            // disNum3
            // 
            this.disNum3.BackColor = System.Drawing.Color.White;
            this.disNum3.Location = new System.Drawing.Point(590, 61);
            this.disNum3.Name = "disNum3";
            this.disNum3.Size = new System.Drawing.Size(100, 22);
            this.disNum3.TabIndex = 10;
            // 
            // biggestNum
            // 
            this.biggestNum.Location = new System.Drawing.Point(211, 271);
            this.biggestNum.Name = "biggestNum";
            this.biggestNum.Size = new System.Drawing.Size(100, 22);
            this.biggestNum.TabIndex = 11;
            // 
            // smallestNum
            // 
            this.smallestNum.Location = new System.Drawing.Point(523, 271);
            this.smallestNum.Name = "smallestNum";
            this.smallestNum.Size = new System.Drawing.Size(100, 22);
            this.smallestNum.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(722, 318);
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
            this.Name = "Form1";
            this.Text = "Find Number";
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
    }
}

