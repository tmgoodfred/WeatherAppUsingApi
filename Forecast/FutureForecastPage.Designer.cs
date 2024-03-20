namespace WeatherAppUsingApi
{
    partial class FutureForecastPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FutureForecastPage));
            this.backBtn = new System.Windows.Forms.Button();
            this.maxTempTxt = new System.Windows.Forms.TextBox();
            this.minTempTxt = new System.Windows.Forms.TextBox();
            this.willItRainTxt = new System.Windows.Forms.TextBox();
            this.chanceOfRainTxt = new System.Windows.Forms.TextBox();
            this.conditionTxt = new System.Windows.Forms.TextBox();
            this.conditionImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.conditionImg)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(171, 245);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // maxTempTxt
            // 
            this.maxTempTxt.Location = new System.Drawing.Point(228, 37);
            this.maxTempTxt.Name = "maxTempTxt";
            this.maxTempTxt.ReadOnly = true;
            this.maxTempTxt.Size = new System.Drawing.Size(100, 20);
            this.maxTempTxt.TabIndex = 1;
            // 
            // minTempTxt
            // 
            this.minTempTxt.Location = new System.Drawing.Point(228, 73);
            this.minTempTxt.Name = "minTempTxt";
            this.minTempTxt.ReadOnly = true;
            this.minTempTxt.Size = new System.Drawing.Size(100, 20);
            this.minTempTxt.TabIndex = 2;
            // 
            // willItRainTxt
            // 
            this.willItRainTxt.Location = new System.Drawing.Point(228, 112);
            this.willItRainTxt.Name = "willItRainTxt";
            this.willItRainTxt.ReadOnly = true;
            this.willItRainTxt.Size = new System.Drawing.Size(100, 20);
            this.willItRainTxt.TabIndex = 3;
            // 
            // chanceOfRainTxt
            // 
            this.chanceOfRainTxt.Location = new System.Drawing.Point(228, 150);
            this.chanceOfRainTxt.Name = "chanceOfRainTxt";
            this.chanceOfRainTxt.ReadOnly = true;
            this.chanceOfRainTxt.Size = new System.Drawing.Size(100, 20);
            this.chanceOfRainTxt.TabIndex = 4;
            // 
            // conditionTxt
            // 
            this.conditionTxt.Location = new System.Drawing.Point(228, 188);
            this.conditionTxt.Name = "conditionTxt";
            this.conditionTxt.ReadOnly = true;
            this.conditionTxt.Size = new System.Drawing.Size(100, 20);
            this.conditionTxt.TabIndex = 5;
            // 
            // conditionImg
            // 
            this.conditionImg.Location = new System.Drawing.Point(35, 82);
            this.conditionImg.Name = "conditionImg";
            this.conditionImg.Size = new System.Drawing.Size(64, 64);
            this.conditionImg.TabIndex = 6;
            this.conditionImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Max Temp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Min Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Will it Rain?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Chance of Rain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Overall Condition";
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(159, 9);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(0, 13);
            this.locationLabel.TabIndex = 12;
            // 
            // FutureForecastPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 312);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conditionImg);
            this.Controls.Add(this.conditionTxt);
            this.Controls.Add(this.chanceOfRainTxt);
            this.Controls.Add(this.willItRainTxt);
            this.Controls.Add(this.minTempTxt);
            this.Controls.Add(this.maxTempTxt);
            this.Controls.Add(this.backBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FutureForecastPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forecast";
            ((System.ComponentModel.ISupportInitialize)(this.conditionImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox maxTempTxt;
        private System.Windows.Forms.TextBox minTempTxt;
        private System.Windows.Forms.TextBox willItRainTxt;
        private System.Windows.Forms.TextBox chanceOfRainTxt;
        private System.Windows.Forms.TextBox conditionTxt;
        private System.Windows.Forms.PictureBox conditionImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label locationLabel;
    }
}