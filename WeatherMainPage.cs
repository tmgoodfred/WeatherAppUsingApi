using System;
using System.Windows.Forms;

namespace WeatherAppUsingApi
{
    public partial class WeatherMainPage : Form
    {
        WeatherData weatherData = new WeatherData();
        PopulateWeatherInfo currentWeatherInfo = new PopulateWeatherInfo();

        public WeatherMainPage()
        {
            InitializeComponent();
        }

        private void getTempBtn_Click(object sender, EventArgs e)
        {
            weatherData = currentWeatherInfo.PopulateWeatherData(ZipCodeData());
            tempTxt.Text = weatherData.temperature;
            iconImg.ImageLocation = weatherData.iconUrl;
            cityStateLabel.Text = weatherData.cityName + ", " + weatherData.countryName;
            windLabel.Text = GetWindInfo(weatherData.windSpeed);
        }

        public string GetWindInfo(string windSpeed)
        {
            string stringToReturn;
            double windspeedParsed = Double.Parse(windSpeed);
            if (windspeedParsed < 8)
            {
                stringToReturn = "Barely any wind";
            }
            else if (windspeedParsed > 8 && windspeedParsed < 20)
            {
                stringToReturn = "Nice little breeze";
            }
            else
            {
                stringToReturn = "IT'S REAL WIMDY";
            }
            return stringToReturn;
        }

        public string ZipCodeData()
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
            return zipCode;
        }
    }
}
