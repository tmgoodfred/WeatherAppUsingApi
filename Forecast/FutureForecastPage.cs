using System;
using System.Windows.Forms;

namespace WeatherAppUsingApi
{
    public partial class FutureForecastPage : Form
    {
        ForecastData forecastDataNow = new ForecastData();
        ForecastData forecastDataDay1 = new ForecastData();
        ForecastData forecastDataDay2 = new ForecastData();
        ForecastData forecastDataDay3 = new ForecastData();
        ForecastData forecastDataDay4 = new ForecastData();
        ForecastData forecastDataDay5 = new ForecastData();
        ForecastData forecastDataDay6 = new ForecastData();
        ForecastData forecastDataDay7 = new ForecastData();

        PopulateForecastInfo currentForecastInfo = new PopulateForecastInfo();
        string zipCode;

        public FutureForecastPage(string zipCode, string location)
        {
            InitializeComponent();
            this.zipCode = zipCode;
            forecastDataNow = currentForecastInfo.PopulateForecastData(zipCode, 0);
            maxTempTxt.Text = forecastDataNow.maxTemp+" f";
            minTempTxt.Text = forecastDataNow.minTemp+" f";
            willItRainTxt.Text = RainResult(forecastDataNow);
            chanceOfRainTxt.Text = forecastDataNow.chanceOfRain + "%";
            conditionTxt.Text = forecastDataNow.overallCondition;
            conditionImg.ImageLocation = forecastDataNow.overallConditionUrl;
            locationLabel.Text = location;

            forecastDataDay1 = currentForecastInfo.PopulateForecastData(zipCode, 1);
            maxTempDay1Txt.Text = forecastDataDay1.maxTemp;
            minTempDay1Txt.Text = forecastDataDay1.minTemp;
            rainDay1Txt.Text = RainResult(forecastDataDay1);
            condDay1Txt.Text = forecastDataDay1.overallCondition;
            day1Lbl.Text = forecastDataDay1.currentDay;
            heatIndexDay1Txt.Text = forecastDataDay1.heatIndex;

            forecastDataDay2 = currentForecastInfo.PopulateForecastData(zipCode, 2);
            maxTempDay2Txt.Text = forecastDataDay2.maxTemp;
            minTempDay2Txt.Text = forecastDataDay2.minTemp;
            rainDay2Txt.Text = RainResult(forecastDataDay2);
            condDay2Txt.Text = forecastDataDay2.overallCondition;
            day2Lbl.Text = forecastDataDay2.currentDay;
            heatIndexDay2Txt.Text = forecastDataDay2.heatIndex;

            forecastDataDay3 = currentForecastInfo.PopulateForecastData(zipCode, 3);
            maxTempDay3Txt.Text = forecastDataDay3.maxTemp;
            minTempDay3Txt.Text = forecastDataDay3.minTemp;
            rainDay3Txt.Text = RainResult(forecastDataDay3);
            condDay3Txt.Text = forecastDataDay3.overallCondition;
            day3Lbl.Text = forecastDataDay3.currentDay;
            heatIndexDay3Txt.Text = forecastDataDay3.heatIndex;

            forecastDataDay4 = currentForecastInfo.PopulateForecastData(zipCode, 4);
            maxTempDay4Txt.Text = forecastDataDay4.maxTemp;
            minTempDay4Txt.Text = forecastDataDay4.minTemp;
            rainDay4Txt.Text = RainResult(forecastDataDay4);
            condDay4Txt.Text = forecastDataDay4.overallCondition;
            day4Lbl.Text = forecastDataDay4.currentDay;
            heatIndexDay4Txt.Text = forecastDataDay4.heatIndex;

            forecastDataDay5 = currentForecastInfo.PopulateForecastData(zipCode, 5);
            maxTempDay5Txt.Text = forecastDataDay5.maxTemp;
            minTempDay5Txt.Text = forecastDataDay5.minTemp;
            rainDay5Txt.Text = RainResult(forecastDataDay1);
            condDay5Txt.Text = forecastDataDay5.overallCondition;
            day5Lbl.Text = forecastDataDay5.currentDay;
            heatIndexDay5Txt.Text = forecastDataDay5.heatIndex;

            forecastDataDay6 = currentForecastInfo.PopulateForecastData(zipCode, 6);
            maxTempDay6Txt.Text = forecastDataDay6.maxTemp;
            minTempDay6Txt.Text = forecastDataDay6.minTemp;
            rainDay6Txt.Text = RainResult(forecastDataDay6);
            condDay6Txt.Text = forecastDataDay6.overallCondition;
            day6Lbl.Text = forecastDataDay6.currentDay;
            heatIndexDay6Txt.Text = forecastDataDay6.heatIndex;

            forecastDataDay7 = currentForecastInfo.PopulateForecastData(zipCode, 7);
            maxTempDay7Txt.Text = forecastDataDay7.maxTemp;
            minTempDay7Txt.Text = forecastDataDay7.minTemp;
            rainDay7Txt.Text = RainResult(forecastDataDay7);
            condDay7Txt.Text = forecastDataDay7.overallCondition;
            day7Lbl.Text = forecastDataDay7.currentDay;
            heatIndexDay7Txt.Text = forecastDataDay7.heatIndex;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            WeatherMainPage weatherMainPage = new WeatherMainPage(zipCode);
            weatherMainPage.Show();
            EventArgs eventArgs = new EventArgs();
            weatherMainPage.getTempBtn_Click(Text = "Get Weather", eventArgs);
        }

        private string RainResult(ForecastData forecast)
        {
            string toReturn = "";
            if (forecast.willItRain == "1")
            {
                toReturn = "Yes";
            }
            else
            {
                toReturn = "No";
            }
            return toReturn;
        }
    }
}
