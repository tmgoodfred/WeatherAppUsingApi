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
            this.SuspendLayout();
            // 
            // tempTxt
            // 
            this.tempTxt.Location = new System.Drawing.Point(95, 66);
            this.tempTxt.Name = "tempTxt";
            this.tempTxt.Size = new System.Drawing.Size(100, 20);
            this.tempTxt.TabIndex = 0;
            // 
            // getTempBtn
            // 
            this.getTempBtn.Location = new System.Drawing.Point(104, 172);
            this.getTempBtn.Name = "getTempBtn";
            this.getTempBtn.Size = new System.Drawing.Size(82, 23);
            this.getTempBtn.TabIndex = 1;
            this.getTempBtn.Text = "Get Weather";
            this.getTempBtn.UseVisualStyleBackColor = true;
            this.getTempBtn.Click += new System.EventHandler(this.getTempBtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.getTempBtn);
            this.Controls.Add(this.tempTxt);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tempTxt;
        private System.Windows.Forms.Button getTempBtn;
    }
}

