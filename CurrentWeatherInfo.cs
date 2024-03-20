using System.Xml;

namespace WeatherAppUsingApi
{
    internal class CurrentWeatherInfo
    {
        WeatherData weatherData = new WeatherData();
        WeatherApiCall callTheApi = new WeatherApiCall();
        XmlDocument responseXml = new XmlDocument();

        public WeatherData PopulateWeatherData(string zipCode)
        {
            responseXml = callTheApi.CallApi(zipCode);

            weatherData.cityName = GetNodeData("name",responseXml);
            weatherData.regionName = GetNodeData("region", responseXml);
            weatherData.countryName = GetNodeData("country", responseXml);
            weatherData.timeCurrently = GetNodeData("localtime", responseXml);
            weatherData.temperature = GetNodeData("temp_f", responseXml);
            weatherData.windSpeed = GetNodeData("wind_mph", responseXml);
            weatherData.windDirection = GetNodeData("wind_dir", responseXml);
            weatherData.tempFeelsLike = GetNodeData("feelslike_f", responseXml);
            weatherData.humidity = GetNodeData("humidity", responseXml);
            weatherData.iconUrl = GetNodeData("icon", responseXml);

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
    }
}
