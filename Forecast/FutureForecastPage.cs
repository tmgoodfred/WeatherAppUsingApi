using System;
using System.Windows.Forms;

namespace WeatherAppUsingApi
{
    public partial class FutureForecastPage : Form
    {
        ForecastData forecastData = new ForecastData();
        PopulateForecastInfo currentForecastInfo = new PopulateForecastInfo();
        string zipCode;

        public FutureForecastPage(string zipCode)
        {
            InitializeComponent();
            this.zipCode = zipCode;
            forecastData = currentForecastInfo.PopulateForecastData(zipCode);
            maxTempTxt.Text = forecastData.maxTemp+" f";
            minTempTxt.Text = forecastData.minTemp+" f";
            if (forecastData.willItRain == "1")
            {
                willItRainTxt.Text = "Yes";
            }
            else
            {
                willItRainTxt.Text = "No";
            }
            chanceOfRainTxt.Text = forecastData.chanceOfRain + "%";
            conditionTxt.Text = forecastData.overallCondition;
            conditionImg.ImageLocation = forecastData.overallConditionUrl;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            WeatherMainPage weatherMainPage = new WeatherMainPage();
            weatherMainPage.Show();
            EventArgs eventArgs = new EventArgs();
            weatherMainPage.getTempBtn_Click(Text = "Get Weather", eventArgs);
        }
    }
}
