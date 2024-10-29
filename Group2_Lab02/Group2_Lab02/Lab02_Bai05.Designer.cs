namespace Group2_Lab02
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.gbFileContent = new System.Windows.Forms.GroupBox();
            this.richtb = new System.Windows.Forms.RichTextBox();
            this.treeView = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.gbFileContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.LightCyan;
            this.pictureBox.Location = new System.Drawing.Point(12, 41);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1296, 926);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // gbFileContent
            // 
            this.gbFileContent.Controls.Add(this.pictureBox);
            this.gbFileContent.Controls.Add(this.richtb);
            this.gbFileContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFileContent.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gbFileContent.Location = new System.Drawing.Point(454, 6);
            this.gbFileContent.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbFileContent.Name = "gbFileContent";
            this.gbFileContent.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbFileContent.Size = new System.Drawing.Size(1326, 967);
            this.gbFileContent.TabIndex = 3;
            this.gbFileContent.TabStop = false;
            this.gbFileContent.Text = "File Content";
            // 
            // richtb
            // 
            this.richtb.Location = new System.Drawing.Point(12, 41);
            this.richtb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.richtb.Name = "richtb";
            this.richtb.Size = new System.Drawing.Size(1298, 922);
            this.richtb.TabIndex = 0;
            this.richtb.Text = "";
            // 
            // treeView
            // 
            this.treeView.BackColor = System.Drawing.Color.Azure;
            this.treeView.Location = new System.Drawing.Point(4, 6);
            this.treeView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(434, 963);
            this.treeView.TabIndex = 2;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick_1);
            // 
            // Bai05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1786, 978);
            this.Controls.Add(this.gbFileContent);
            this.Controls.Add(this.treeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Bai05";
            this.Text = "Bài 05 Duyệt thư mục";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.gbFileContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox gbFileContent;
        private System.Windows.Forms.RichTextBox richtb;
        private System.Windows.Forms.TreeView treeView;
    }
}