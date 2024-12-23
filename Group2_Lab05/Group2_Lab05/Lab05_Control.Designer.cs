namespace Group2_Lab05
{
    partial class Lab05_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab05_Control));
            this.btnBai04 = new System.Windows.Forms.Button();
            this.btnBai02 = new System.Windows.Forms.Button();
            this.btnBai01 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBai04
            // 
            this.btnBai04.BackColor = System.Drawing.Color.LightPink;
            this.btnBai04.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai04.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBai04.Location = new System.Drawing.Point(439, 229);
            this.btnBai04.Name = "btnBai04";
            this.btnBai04.Size = new System.Drawing.Size(124, 43);
            this.btnBai04.TabIndex = 16;
            this.btnBai04.Text = "Bài 04";
            this.btnBai04.UseVisualStyleBackColor = false;
            this.btnBai04.Click += new System.EventHandler(this.btnBai04_Click);
            // 
            // btnBai02
            // 
            this.btnBai02.BackColor = System.Drawing.Color.Thistle;
            this.btnBai02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai02.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBai02.Location = new System.Drawing.Point(307, 229);
            this.btnBai02.Name = "btnBai02";
            this.btnBai02.Size = new System.Drawing.Size(124, 43);
            this.btnBai02.TabIndex = 15;
            this.btnBai02.Text = "Bài 02";
            this.btnBai02.UseVisualStyleBackColor = false;
            this.btnBai02.Click += new System.EventHandler(this.btnBai02_Click);
            // 
            // btnBai01
            // 
            this.btnBai01.BackColor = System.Drawing.Color.LightPink;
            this.btnBai01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBai01.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnBai01.Location = new System.Drawing.Point(176, 229);
            this.btnBai01.Name = "btnBai01";
            this.btnBai01.Size = new System.Drawing.Size(122, 43);
            this.btnBai01.TabIndex = 13;
            this.btnBai01.Text = "Bài 01";
            this.btnBai01.UseVisualStyleBackColor = false;
            this.btnBai01.Click += new System.EventHandler(this.btnBai01_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(781, 397);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // Lab05_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 397);
            this.Controls.Add(this.btnBai04);
            this.Controls.Add(this.btnBai02);
            this.Controls.Add(this.btnBai01);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lab05_Control";
            this.Text = "Menu ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBai04;
        private System.Windows.Forms.Button btnBai02;
        private System.Windows.Forms.Button btnBai01;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

