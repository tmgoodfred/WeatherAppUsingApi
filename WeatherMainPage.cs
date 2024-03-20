using System;
using System.Windows.Forms;

namespace WeatherAppUsingApi
{
    public partial class WeatherMainPage : Form
    {
        WeatherData weatherData = new WeatherData();
        CurrentWeatherInfo currentWeatherInfo = new CurrentWeatherInfo();

        public WeatherMainPage()
        {
            InitializeComponent();
        }

        private void getTempBtn_Click(object sender, EventArgs e)
        {
            string zipCode;
            if (zipCodeTxt.Text != null && zipCodeTxt.Text != "")
            {
                zipCode = zipCodeTxt.Text;
            }
            else
            {
                LocationApiCall locationApiCall = new LocationApiCall();
                zipCode = locationApiCall.CallApiAndReturnZip();
            }
            weatherData = currentWeatherInfo.PopulateWeatherData(zipCode);
            tempTxt.Text = weatherData.temperature;
            iconImg.ImageLocation = weatherData.iconUrl;
            cityStateLabel.Text = weatherData.cityName + ", " + weatherData.countryName;

            string windspeed = weatherData.windSpeed;
            double windspeedParsed = Double.Parse(windspeed);
            if (windspeedParsed < 8)
            {
                windLabel.Text = "Barely any wind";
            }
            else if (windspeedParsed > 8 && windspeedParsed < 20)
            {
                windLabel.Text = "Nice little breeze";
            }
            else
            {
                windLabel.Text = "IT'S REAL WIMDY";
            }
        }
    }
}
