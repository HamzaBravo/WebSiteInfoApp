namespace WebSiteInfoApp
{
    partial class F_MainApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_MainApp));
            this.TXTttargetUrl = new System.Windows.Forms.TextBox();
            this.BTNsearch = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::WebSiteInfoApp.WaitForm1), true, true);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXTttargetUrl
            // 
            this.TXTttargetUrl.BackColor = System.Drawing.Color.Black;
            this.TXTttargetUrl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTttargetUrl.ForeColor = System.Drawing.Color.White;
            this.TXTttargetUrl.Location = new System.Drawing.Point(91, 20);
            this.TXTttargetUrl.Name = "TXTttargetUrl";
            this.TXTttargetUrl.Size = new System.Drawing.Size(228, 27);
            this.TXTttargetUrl.TabIndex = 0;
            // 
            // BTNsearch
            // 
            this.BTNsearch.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTNsearch.Appearance.Options.UseFont = true;
            this.BTNsearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNsearch.ImageOptions.Image")));
            this.BTNsearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BTNsearch.Location = new System.Drawing.Point(12, 57);
            this.BTNsearch.Name = "BTNsearch";
            this.BTNsearch.Size = new System.Drawing.Size(307, 44);
            this.BTNsearch.TabIndex = 1;
            this.BTNsearch.Text = "Search";
            this.BTNsearch.Click += new System.EventHandler(this.BTNsearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hedef URL";
            // 
            // txtresult
            // 
            this.txtresult.BackColor = System.Drawing.Color.Black;
            this.txtresult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtresult.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtresult.ForeColor = System.Drawing.Color.White;
            this.txtresult.Location = new System.Drawing.Point(3, 17);
            this.txtresult.Multiline = true;
            this.txtresult.Name = "txtresult";
            this.txtresult.Size = new System.Drawing.Size(301, 154);
            this.txtresult.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.txtresult);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 174);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Keywords";
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // F_MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 304);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNsearch);
            this.Controls.Add(this.TXTttargetUrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("F_MainApp.IconOptions.SvgImage")));
            this.LookAndFeel.SkinName = "High Contrast";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "F_MainApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URL KEYWORDS SEARCH";
            this.Load += new System.EventHandler(this.F_MainApp_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTttargetUrl;
        private DevExpress.XtraEditors.SimpleButton BTNsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}

