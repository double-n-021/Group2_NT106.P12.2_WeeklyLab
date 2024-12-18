namespace Group2_Lab04
{
    partial class Lab04_Bai03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab04_Bai03));
            this.btVS = new System.Windows.Forms.Button();
            this.btDF = new System.Windows.Forms.Button();
            this.btDR = new System.Windows.Forms.Button();
            this.btReload = new System.Windows.Forms.Button();
            this.btLoad = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.wvShow = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.wvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btVS
            // 
            this.btVS.Location = new System.Drawing.Point(402, 43);
            this.btVS.Name = "btVS";
            this.btVS.Size = new System.Drawing.Size(135, 32);
            this.btVS.TabIndex = 12;
            this.btVS.Text = "View Sources";
            this.btVS.UseVisualStyleBackColor = true;
            this.btVS.Click += new System.EventHandler(this.btVS_Click);
            // 
            // btDF
            // 
            this.btDF.Location = new System.Drawing.Point(284, 43);
            this.btDF.Name = "btDF";
            this.btDF.Size = new System.Drawing.Size(112, 32);
            this.btDF.TabIndex = 11;
            this.btDF.Text = "Down Files";
            this.btDF.UseVisualStyleBackColor = true;
            this.btDF.Click += new System.EventHandler(this.btDF_Click);
            // 
            // btDR
            // 
            this.btDR.Location = new System.Drawing.Point(543, 43);
            this.btDR.Name = "btDR";
            this.btDR.Size = new System.Drawing.Size(135, 32);
            this.btDR.TabIndex = 10;
            this.btDR.Text = "Down Resources";
            this.btDR.UseVisualStyleBackColor = true;
            this.btDR.Click += new System.EventHandler(this.btDR_Click);
            // 
            // btReload
            // 
            this.btReload.Location = new System.Drawing.Point(592, 10);
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(85, 27);
            this.btReload.TabIndex = 9;
            this.btReload.Text = "Reload";
            this.btReload.UseVisualStyleBackColor = true;
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // btLoad
            // 
            this.btLoad.Location = new System.Drawing.Point(9, 10);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(85, 27);
            this.btLoad.TabIndex = 8;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = true;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // tbURL
            // 
            this.tbURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbURL.Location = new System.Drawing.Point(100, 12);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(486, 22);
            this.tbURL.TabIndex = 7;
            // 
            // wvShow
            // 
            this.wvShow.AllowExternalDrop = true;
            this.wvShow.BackColor = System.Drawing.Color.LightGray;
            this.wvShow.CreationProperties = null;
            this.wvShow.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvShow.Location = new System.Drawing.Point(8, 80);
            this.wvShow.Name = "wvShow";
            this.wvShow.Size = new System.Drawing.Size(669, 367);
            this.wvShow.TabIndex = 13;
            this.wvShow.ZoomFactor = 1D;
            // 
            // Lab04_Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(692, 459);
            this.Controls.Add(this.wvShow);
            this.Controls.Add(this.btVS);
            this.Controls.Add(this.btDF);
            this.Controls.Add(this.btDR);
            this.Controls.Add(this.btReload);
            this.Controls.Add(this.btLoad);
            this.Controls.Add(this.tbURL);
            this.Name = "Lab04_Bai03";
            this.Text = "Lab04_Bai03";
            ((System.ComponentModel.ISupportInitialize)(this.wvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVS;
        private System.Windows.Forms.Button btDF;
        private System.Windows.Forms.Button btDR;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.TextBox tbURL;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvShow;
    }
}