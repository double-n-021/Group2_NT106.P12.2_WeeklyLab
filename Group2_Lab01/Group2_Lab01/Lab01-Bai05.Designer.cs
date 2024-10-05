namespace Group2_Lab01
{
    partial class Bai05
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai05));
            this.txtName = new System.Windows.Forms.TextBox();
            this.chooseSex = new System.Windows.Forms.ComboBox();
            this.txtScore2 = new System.Windows.Forms.TextBox();
            this.txtScore1 = new System.Windows.Forms.TextBox();
            this.txtScore3 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Score3 = new System.Windows.Forms.Label();
            this.Score2 = new System.Windows.Forms.Label();
            this.Score1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.candidateList = new System.Windows.Forms.DataGridView();
            this.enterCandidate = new System.Windows.Forms.GroupBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.statisticsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.candidateList)).BeginInit();
            this.enterCandidate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(107, 42);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 26);
            this.txtName.TabIndex = 0;
            // 
            // chooseSex
            // 
            this.chooseSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseSex.FormattingEnabled = true;
            this.chooseSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.chooseSex.Location = new System.Drawing.Point(107, 73);
            this.chooseSex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseSex.Name = "chooseSex";
            this.chooseSex.Size = new System.Drawing.Size(211, 28);
            this.chooseSex.TabIndex = 1;
            // 
            // txtScore2
            // 
            this.txtScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore2.Location = new System.Drawing.Point(482, 70);
            this.txtScore2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(135, 26);
            this.txtScore2.TabIndex = 2;
            // 
            // txtScore1
            // 
            this.txtScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore1.Location = new System.Drawing.Point(482, 39);
            this.txtScore1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(135, 26);
            this.txtScore1.TabIndex = 3;
            // 
            // txtScore3
            // 
            this.txtScore3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore3.Location = new System.Drawing.Point(482, 101);
            this.txtScore3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(135, 26);
            this.txtScore3.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(25, 141);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 26);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(139, 142);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 25);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Họ và Tên";
            // 
            // Score3
            // 
            this.Score3.AutoSize = true;
            this.Score3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score3.Location = new System.Drawing.Point(374, 105);
            this.Score3.Name = "Score3";
            this.Score3.Size = new System.Drawing.Size(99, 20);
            this.Score3.TabIndex = 9;
            this.Score3.Text = "Điểm Môn 3";
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score2.Location = new System.Drawing.Point(374, 73);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(99, 20);
            this.Score2.TabIndex = 10;
            this.Score2.Text = "Điểm Môn 2";
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score1.Location = new System.Drawing.Point(374, 42);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(99, 20);
            this.Score1.TabIndex = 11;
            this.Score1.Text = "Điểm Môn 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phái";
            // 
            // candidateList
            // 
            this.candidateList.BackgroundColor = System.Drawing.Color.MintCream;
            this.candidateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateList.Location = new System.Drawing.Point(12, 248);
            this.candidateList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.candidateList.Name = "candidateList";
            this.candidateList.RowHeadersWidth = 51;
            this.candidateList.RowTemplate.Height = 24;
            this.candidateList.Size = new System.Drawing.Size(1293, 221);
            this.candidateList.TabIndex = 13;
            this.candidateList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.candidateList_CellContentClick);
            // 
            // enterCandidate
            // 
            this.enterCandidate.BackColor = System.Drawing.Color.LightGreen;
            this.enterCandidate.Controls.Add(this.btnStatistics);
            this.enterCandidate.Controls.Add(this.label2);
            this.enterCandidate.Controls.Add(this.btnDelete);
            this.enterCandidate.Controls.Add(this.pictureBox2);
            this.enterCandidate.Controls.Add(this.Score3);
            this.enterCandidate.Controls.Add(this.btnSave);
            this.enterCandidate.Controls.Add(this.Score2);
            this.enterCandidate.Controls.Add(this.txtScore3);
            this.enterCandidate.Controls.Add(this.Score1);
            this.enterCandidate.Controls.Add(this.txtScore2);
            this.enterCandidate.Controls.Add(this.txtScore1);
            this.enterCandidate.Controls.Add(this.label6);
            this.enterCandidate.Controls.Add(this.txtName);
            this.enterCandidate.Controls.Add(this.chooseSex);
            this.enterCandidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterCandidate.Location = new System.Drawing.Point(40, 31);
            this.enterCandidate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterCandidate.Name = "enterCandidate";
            this.enterCandidate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enterCandidate.Size = new System.Drawing.Size(739, 196);
            this.enterCandidate.TabIndex = 14;
            this.enterCandidate.TabStop = false;
            this.enterCandidate.Text = "Nhập Thí Sinh";
            // 
            // btnStatistics
            // 
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.Location = new System.Drawing.Point(254, 142);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(92, 25);
            this.btnStatistics.TabIndex = 13;
            this.btnStatistics.Text = "Thống kê";
            this.btnStatistics.UseVisualStyleBackColor = true;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(646, 105);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // statisticsGrid
            // 
            this.statisticsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statisticsGrid.Location = new System.Drawing.Point(804, 31);
            this.statisticsGrid.Name = "statisticsGrid";
            this.statisticsGrid.RowHeadersWidth = 51;
            this.statisticsGrid.RowTemplate.Height = 24;
            this.statisticsGrid.Size = new System.Drawing.Size(501, 196);
            this.statisticsGrid.TabIndex = 17;
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1320, 480);
            this.Controls.Add(this.statisticsGrid);
            this.Controls.Add(this.candidateList);
            this.Controls.Add(this.enterCandidate);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bai05";
            this.Text = "Candidate Management";
            ((System.ComponentModel.ISupportInitialize)(this.candidateList)).EndInit();
            this.enterCandidate.ResumeLayout(false);
            this.enterCandidate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox chooseSex;
        private System.Windows.Forms.TextBox txtScore2;
        private System.Windows.Forms.TextBox txtScore1;
        private System.Windows.Forms.TextBox txtScore3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Score3;
        private System.Windows.Forms.Label Score2;
        private System.Windows.Forms.Label Score1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView candidateList;
        private System.Windows.Forms.GroupBox enterCandidate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView statisticsGrid;
        private System.Windows.Forms.Button btnStatistics;
    }
}