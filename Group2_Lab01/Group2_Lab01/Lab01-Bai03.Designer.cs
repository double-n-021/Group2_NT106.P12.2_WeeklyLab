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
            this.label1 = new System.Windows.Forms.Label();
            this.enterNum = new System.Windows.Forms.TextBox();
            this.btnReadNum = new System.Windows.Forms.Button();
            this.showResults = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số:";

            // 
            // enterNum
            // 
            this.enterNum.Location = new System.Drawing.Point(157, 61);
            this.enterNum.Name = "enterNum";
            this.enterNum.Size = new System.Drawing.Size(397, 22);
            this.enterNum.TabIndex = 1;
            // 
            // btnReadNum
            // 
            this.btnReadNum.Location = new System.Drawing.Point(260, 102);
            this.btnReadNum.Name = "btnReadNum";
            this.btnReadNum.Size = new System.Drawing.Size(178, 45);
            this.btnReadNum.TabIndex = 2;
            this.btnReadNum.Text = "Đọc số";
            this.btnReadNum.UseVisualStyleBackColor = true;
            this.btnReadNum.Click += new System.EventHandler(this.btnReadNum_Click);
            // 
            // showResults
            // 
            this.showResults.Location = new System.Drawing.Point(178, 183);
            this.showResults.Multiline = true;
            this.showResults.Name = "showResults";
            this.showResults.Size = new System.Drawing.Size(350, 41);
            this.showResults.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 273);
            this.Controls.Add(this.showResults);
            this.Controls.Add(this.btnReadNum);
            this.Controls.Add(this.enterNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Read Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterNum;
        private System.Windows.Forms.Button btnReadNum;
        private System.Windows.Forms.TextBox showResults;
    }
}