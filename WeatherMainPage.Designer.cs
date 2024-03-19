namespace WeatherAppUsingApi
{
    partial class WeatherMainPage
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
            this.tempTxt = new System.Windows.Forms.TextBox();
            this.getTempBtn = new System.Windows.Forms.Button();
            this.iconImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.windLabel = new System.Windows.Forms.Label();
            this.zipCodeTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cityStateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconImg)).BeginInit();
            this.SuspendLayout();
            // 
            // tempTxt
            // 
            this.tempTxt.Location = new System.Drawing.Point(113, 63);
            this.tempTxt.Name = "tempTxt";
            this.tempTxt.ReadOnly = true;
            this.tempTxt.Size = new System.Drawing.Size(56, 20);
            this.tempTxt.TabIndex = 0;
            this.tempTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // getTempBtn
            // 
            this.getTempBtn.Location = new System.Drawing.Point(101, 128);
            this.getTempBtn.Name = "getTempBtn";
            this.getTempBtn.Size = new System.Drawing.Size(82, 23);
            this.getTempBtn.TabIndex = 1;
            this.getTempBtn.Text = "Get Weather";
            this.getTempBtn.UseVisualStyleBackColor = true;
            this.getTempBtn.Click += new System.EventHandler(this.getTempBtn_Click);
            // 
            // iconImg
            // 
            this.iconImg.Location = new System.Drawing.Point(12, 47);
            this.iconImg.Name = "iconImg";
            this.iconImg.Size = new System.Drawing.Size(64, 64);
            this.iconImg.TabIndex = 2;
            this.iconImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Temp (in F)";
            // 
            // windLabel
            // 
            this.windLabel.AutoSize = true;
            this.windLabel.Location = new System.Drawing.Point(110, 98);
            this.windLabel.Name = "windLabel";
            this.windLabel.Size = new System.Drawing.Size(0, 13);
            this.windLabel.TabIndex = 4;
            // 
            // zipCodeTxt
            // 
            this.zipCodeTxt.Location = new System.Drawing.Point(141, 12);
            this.zipCodeTxt.Name = "zipCodeTxt";
            this.zipCodeTxt.Size = new System.Drawing.Size(100, 20);
            this.zipCodeTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Location: (Zip code)";
            // 
            // cityStateLabel
            // 
            this.cityStateLabel.AutoSize = true;
            this.cityStateLabel.Location = new System.Drawing.Point(190, 137);
            this.cityStateLabel.Name = "cityStateLabel";
            this.cityStateLabel.Size = new System.Drawing.Size(0, 13);
            this.cityStateLabel.TabIndex = 7;
            // 
            // WeatherMainPage
            // 
            this.ClientSize = new System.Drawing.Size(284, 170);
            this.Controls.Add(this.cityStateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zipCodeTxt);
            this.Controls.Add(this.windLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconImg);
            this.Controls.Add(this.getTempBtn);
            this.Controls.Add(this.tempTxt);
            this.Name = "WeatherMainPage";
            ((System.ComponentModel.ISupportInitialize)(this.iconImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tempTxt;
        private System.Windows.Forms.Button getTempBtn;
        private System.Windows.Forms.PictureBox iconImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label windLabel;
        private System.Windows.Forms.TextBox zipCodeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cityStateLabel;
    }
}

