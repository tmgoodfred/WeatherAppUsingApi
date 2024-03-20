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

        public void getTempBtn_Click(object sender, EventArgs e)
        {
            weatherData = currentWeatherInfo.PopulateWeatherData(ZipCodeData());
            tempTxt.Text = weatherData.temperature;
            iconImg.ImageLocation = "https:"+weatherData.iconUrl;

            if (weatherData.regionName != "")
            {
                cityStateLabel.Text = weatherData.cityName + ", " + weatherData.regionName;
            }
            else
            {
                cityStateLabel.Text = weatherData.cityName + ", " + weatherData.countryName;
            }

            windFeelTxt.Text = GetWindInfo(weatherData.windSpeed);
            windDirectionTxt.Text = weatherData.windDirection;
            humidityTxt.Text = weatherData.humidity+"%";
        }

        public string GetWindInfo(string windSpeed)
        {
            string stringToReturn;
            try
            {
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
            }
            catch
            {
                stringToReturn = "";
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

        private void forecastBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FutureForecastPage form = new FutureForecastPage(ZipCodeData());
            form.Show();
        }
    }
}
