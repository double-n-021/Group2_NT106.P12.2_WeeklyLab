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
            ((System.ComponentModel.ISupportInitialize)(this.candidateList)).BeginInit();
            this.enterCandidate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(109, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(211, 22);
            this.txtName.TabIndex = 0;
            // 
            // chooseSex
            // 
            this.chooseSex.FormattingEnabled = true;
            this.chooseSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.chooseSex.Location = new System.Drawing.Point(109, 68);
            this.chooseSex.Name = "chooseSex";
            this.chooseSex.Size = new System.Drawing.Size(211, 24);
            this.chooseSex.TabIndex = 1;
            // 
            // txtScore2
            // 
            this.txtScore2.Location = new System.Drawing.Point(484, 65);
            this.txtScore2.Name = "txtScore2";
            this.txtScore2.Size = new System.Drawing.Size(135, 22);
            this.txtScore2.TabIndex = 2;
            // 
            // txtScore1
            // 
            this.txtScore1.Location = new System.Drawing.Point(484, 34);
            this.txtScore1.Name = "txtScore1";
            this.txtScore1.Size = new System.Drawing.Size(135, 22);
            this.txtScore1.TabIndex = 3;
            // 
            // txtScore3
            // 
            this.txtScore3.Location = new System.Drawing.Point(484, 96);
            this.txtScore3.Name = "txtScore3";
            this.txtScore3.Size = new System.Drawing.Size(135, 22);
            this.txtScore3.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(27, 136);
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
            this.btnDelete.Location = new System.Drawing.Point(141, 137);
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
            this.label2.Location = new System.Drawing.Point(33, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Họ và Tên";
            // 
            // Score3
            // 
            this.Score3.AutoSize = true;
            this.Score3.Location = new System.Drawing.Point(401, 99);
            this.Score3.Name = "Score3";
            this.Score3.Size = new System.Drawing.Size(77, 16);
            this.Score3.TabIndex = 9;
            this.Score3.Text = "Điểm Môn 3";
            // 
            // Score2
            // 
            this.Score2.AutoSize = true;
            this.Score2.Location = new System.Drawing.Point(401, 68);
            this.Score2.Name = "Score2";
            this.Score2.Size = new System.Drawing.Size(77, 16);
            this.Score2.TabIndex = 10;
            this.Score2.Text = "Điểm Môn 2";
            // 
            // Score1
            // 
            this.Score1.AutoSize = true;
            this.Score1.Location = new System.Drawing.Point(401, 37);
            this.Score1.Name = "Score1";
            this.Score1.Size = new System.Drawing.Size(77, 16);
            this.Score1.TabIndex = 11;
            this.Score1.Text = "Điểm Môn 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phái";
            // 
            // candidateList
            // 
            this.candidateList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidateList.Location = new System.Drawing.Point(12, 237);
            this.candidateList.Name = "candidateList";
            this.candidateList.RowHeadersWidth = 51;
            this.candidateList.RowTemplate.Height = 24;
            this.candidateList.Size = new System.Drawing.Size(1116, 231);
            this.candidateList.TabIndex = 13;
            this.candidateList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.candidateList_CellContentClick);
            // 
            // enterCandidate
            // 
            this.enterCandidate.Controls.Add(this.label2);
            this.enterCandidate.Controls.Add(this.btnDelete);
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
            this.enterCandidate.Location = new System.Drawing.Point(34, 35);
            this.enterCandidate.Name = "enterCandidate";
            this.enterCandidate.Size = new System.Drawing.Size(661, 180);
            this.enterCandidate.TabIndex = 14;
            this.enterCandidate.TabStop = false;
            this.enterCandidate.Text = "Nhập Thí Sinh";
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 480);
            this.Controls.Add(this.candidateList);
            this.Controls.Add(this.enterCandidate);
            this.Name = "Bai05";
            this.Text = "Candidate Management";
            ((System.ComponentModel.ISupportInitialize)(this.candidateList)).EndInit();
            this.enterCandidate.ResumeLayout(false);
            this.enterCandidate.PerformLayout();
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
    }
}