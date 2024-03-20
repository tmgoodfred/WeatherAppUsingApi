using System.Xml;

namespace WeatherAppUsingApi
{
    internal class PopulateForecastInfo
    {
        ForecastData forecastData = new ForecastData();
        WeatherApiCall callTheApi = new WeatherApiCall();
        XmlDocument responseXml = new XmlDocument();

        public ForecastData PopulateForecastData(string zipCode)
        {
            responseXml = callTheApi.CallApi_FutureForecast(zipCode);

            forecastData.maxTemp = GetNodeData("maxtemp_f", responseXml);
            forecastData.minTemp = GetNodeData("mintemp_f", responseXml);
            forecastData.willItRain = GetNodeData("daily_will_it_rain", responseXml);
            forecastData.chanceOfRain = GetNodeData("daily_chance_of_rain", responseXml);
            forecastData.overallCondition = GetNodeData("condition/text", responseXml);
            forecastData.overallConditionUrl = "https:"+GetNodeData("condition/icon", responseXml);

            return forecastData;
        }
        private string GetNodeData(string tagName, XmlDocument responseXml)
        {
            string valueToReturn = "";

            XmlNodeList xmlNodes = responseXml.SelectNodes("//forecast/forecastday/day/"+tagName);
            foreach (XmlNode xmlNode in xmlNodes)
            {
                valueToReturn = xmlNode.InnerText;
            }

            return valueToReturn;
        }
    }
}
