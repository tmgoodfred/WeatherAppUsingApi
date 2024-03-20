using System;
using System.Windows.Forms;

namespace WeatherAppUsingApi
{
    public partial class WeatherMainPage : Form
    {
        WeatherData weatherData = new WeatherData();
        PopulateWeatherInfo currentWeatherInfo = new PopulateWeatherInfo();
        string locationString;
        string masterLocationInfo = "";

        public WeatherMainPage(string locationData)
        {
            InitializeComponent();
            masterLocationInfo = locationData;
            PopulateTextbox(locationData);
        }

        public void getTempBtn_Click(object sender, EventArgs e)
        {
            if (zipCodeTxt.Text != null && zipCodeTxt.Text != "")
            {
                masterLocationInfo = zipCodeTxt.Text;
                PopulateTextbox(zipCodeTxt.Text);
            }
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

        public string ZipCodeData(string zipCodeCurrent)
        {
            string zipCode = "";
            if (zipCodeCurrent != null && zipCodeCurrent != "")
            {
                masterLocationInfo = zipCodeCurrent;
                zipCode = masterLocationInfo;
            }
            else
            {
                LocationApiCall locationApiCall = new LocationApiCall();
                zipCode = locationApiCall.CallApiAndReturnZip();
                masterLocationInfo = zipCode;
            }
            return zipCode;
        }

        private void forecastBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            FutureForecastPage form = new FutureForecastPage(masterLocationInfo, locationString);
            form.Show();
        }

        public void PopulateTextbox(string locationData)
        {
            weatherData = currentWeatherInfo.PopulateWeatherData(ZipCodeData(masterLocationInfo));
            tempTxt.Text = weatherData.temperature;
            iconImg.ImageLocation = "https:" + weatherData.iconUrl;

            if (weatherData.regionName != "")
            {
                locationString = weatherData.cityName + ", " + weatherData.regionName + ", " + weatherData.countryName;
                cityStateLabel.Text = locationString;

            }
            else
            {
                locationString = weatherData.cityName + ", " + weatherData.countryName;
                cityStateLabel.Text = locationString;
            }

            windFeelTxt.Text = GetWindInfo(weatherData.windSpeed);
            windDirectionTxt.Text = weatherData.windDirection;
            humidityTxt.Text = weatherData.humidity + "%";
            theirTimeLabel.Text = "Time and Date at Location: "+ weatherData.timeCurrently;
        }
    }
}
