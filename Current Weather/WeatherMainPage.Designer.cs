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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherMainPage));
            this.zipCodeTxt = new System.Windows.Forms.TextBox();
            this.tempTxt = new System.Windows.Forms.TextBox();
            this.getWeatherBtn = new System.Windows.Forms.Button();
            this.iconImg = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cityStateLabel = new System.Windows.Forms.Label();
            this.windDirectionTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.windFeelTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.humidityTxt = new System.Windows.Forms.TextBox();
            this.forecastBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.iconImg)).BeginInit();
            this.SuspendLayout();
            // 
            // zipCodeTxt
            // 
            this.zipCodeTxt.Location = new System.Drawing.Point(161, 14);
            this.zipCodeTxt.Name = "zipCodeTxt";
            this.zipCodeTxt.Size = new System.Drawing.Size(100, 20);
            this.zipCodeTxt.TabIndex = 0;
            // 
            // tempTxt
            // 
            this.tempTxt.Location = new System.Drawing.Point(152, 62);
            this.tempTxt.Name = "tempTxt";
            this.tempTxt.ReadOnly = true;
            this.tempTxt.Size = new System.Drawing.Size(56, 20);
            this.tempTxt.TabIndex = 5;
            this.tempTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // getWeatherBtn
            // 
            this.getWeatherBtn.Location = new System.Drawing.Point(142, 183);
            this.getWeatherBtn.Name = "getWeatherBtn";
            this.getWeatherBtn.Size = new System.Drawing.Size(82, 23);
            this.getWeatherBtn.TabIndex = 1;
            this.getWeatherBtn.Text = "Get Weather";
            this.getWeatherBtn.UseVisualStyleBackColor = true;
            this.getWeatherBtn.Click += new System.EventHandler(this.getTempBtn_Click);
            // 
            // iconImg
            // 
            this.iconImg.Location = new System.Drawing.Point(57, 33);
            this.iconImg.Name = "iconImg";
            this.iconImg.Size = new System.Drawing.Size(64, 64);
            this.iconImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconImg.TabIndex = 2;
            this.iconImg.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Temp (in F)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Location:";
            // 
            // cityStateLabel
            // 
            this.cityStateLabel.AutoSize = true;
            this.cityStateLabel.Location = new System.Drawing.Point(268, 17);
            this.cityStateLabel.Name = "cityStateLabel";
            this.cityStateLabel.Size = new System.Drawing.Size(0, 13);
            this.cityStateLabel.TabIndex = 7;
            // 
            // windDirectionTxt
            // 
            this.windDirectionTxt.Location = new System.Drawing.Point(161, 124);
            this.windDirectionTxt.Name = "windDirectionTxt";
            this.windDirectionTxt.ReadOnly = true;
            this.windDirectionTxt.Size = new System.Drawing.Size(34, 20);
            this.windDirectionTxt.TabIndex = 8;
            this.windDirectionTxt.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wind Direction";
            // 
            // windFeelTxt
            // 
            this.windFeelTxt.Location = new System.Drawing.Point(161, 98);
            this.windFeelTxt.Name = "windFeelTxt";
            this.windFeelTxt.ReadOnly = true;
            this.windFeelTxt.Size = new System.Drawing.Size(143, 20);
            this.windFeelTxt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "How\'s the wind feel?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "How Humid Is It?";
            // 
            // humidityTxt
            // 
            this.humidityTxt.Location = new System.Drawing.Point(161, 149);
            this.humidityTxt.Name = "humidityTxt";
            this.humidityTxt.ReadOnly = true;
            this.humidityTxt.Size = new System.Drawing.Size(34, 20);
            this.humidityTxt.TabIndex = 13;
            // 
            // forecastBtn
            // 
            this.forecastBtn.Location = new System.Drawing.Point(282, 183);
            this.forecastBtn.Name = "forecastBtn";
            this.forecastBtn.Size = new System.Drawing.Size(75, 23);
            this.forecastBtn.TabIndex = 14;
            this.forecastBtn.Text = "Forecast";
            this.forecastBtn.UseVisualStyleBackColor = true;
            this.forecastBtn.Click += new System.EventHandler(this.forecastBtn_Click);
            // 
            // WeatherMainPage
            // 
            this.ClientSize = new System.Drawing.Size(406, 237);
            this.Controls.Add(this.forecastBtn);
            this.Controls.Add(this.humidityTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.windFeelTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.windDirectionTxt);
            this.Controls.Add(this.cityStateLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zipCodeTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconImg);
            this.Controls.Add(this.getWeatherBtn);
            this.Controls.Add(this.tempTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeatherMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather App";
            ((System.ComponentModel.ISupportInitialize)(this.iconImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tempTxt;
        private System.Windows.Forms.Button getWeatherBtn;
        private System.Windows.Forms.PictureBox iconImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox zipCodeTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cityStateLabel;
        private System.Windows.Forms.TextBox windDirectionTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox windFeelTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox humidityTxt;
        private System.Windows.Forms.Button forecastBtn;
    }
}

