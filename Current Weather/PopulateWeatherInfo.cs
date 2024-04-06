using System.Xml;

namespace WeatherAppUsingApi
{
    internal class PopulateWeatherInfo
    {
        WeatherData weatherData = new WeatherData();
        WeatherApiCall callTheApi = new WeatherApiCall();
        XmlDocument responseXml = new XmlDocument();
        XmlDocument responseXmlNight = new XmlDocument();

        public WeatherData PopulateWeatherData(string zipCode)
        {
            responseXml = callTheApi.CallApi_CurrentWeather(zipCode);

            weatherData.cityName = GetNodeData("name",responseXml);
            weatherData.regionName = GetNodeData("region", responseXml);
            weatherData.countryName = GetNodeData("country", responseXml);
            weatherData.timeCurrently = GetNodeData("localtime", responseXml);
            string dateTomorrow = GetNodeData("localtime", responseXml);
            int year = int.Parse(dateTomorrow.Substring(0, 4));
            int month = int.Parse(dateTomorrow.Substring(5, 2));
            int day = int.Parse(dateTomorrow.Substring(8, 2));
            System.DateTime dateValue = new System.DateTime(year, month, day).AddDays(1);
            dateTomorrow = dateValue.ToString("MM-dd-yyyy");
            weatherData.temperature = GetNodeData("temp_f", responseXml);
            weatherData.windSpeed = GetNodeData("wind_mph", responseXml);
            weatherData.windDirection = GetNodeData("wind_dir", responseXml);
            weatherData.tempFeelsLike = GetNodeData("feelslike_f", responseXml);
            weatherData.humidity = GetNodeData("humidity", responseXml);
            weatherData.iconUrl = GetNodeData("icon", responseXml);
            responseXmlNight = callTheApi.CallApi_GetMidnightForecast(zipCode, dateTomorrow);
            weatherData.nightTemp = GetNightData(responseXmlNight);

            return weatherData;
        }

        private string GetNodeData(string TagName, XmlDocument responseXml)
        {
            string valueToReturn = "";
            XmlNodeList nodeList = responseXml.GetElementsByTagName(TagName);
            foreach (XmlNode node in nodeList)
            {
                valueToReturn = node.InnerText;
            }
            return valueToReturn;
        }
        private string GetNightData(XmlDocument responseXml)
        {
            string valueToReturn = "";
            XmlNodeList nodeList = responseXml.GetElementsByTagName("temp_f");
            foreach (XmlNode node in nodeList)
            {
                valueToReturn = node.InnerText;
            }
            return valueToReturn;
        }
    }
}
