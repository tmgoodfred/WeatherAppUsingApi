using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;

namespace WeatherAppUsingApi
{
    internal class PopulateForecastInfo
    {
        ForecastData forecastData = new ForecastData();
        WeatherApiCall callTheApi = new WeatherApiCall();
        XmlDocument responseXml = new XmlDocument();
        List<string> maxTempList = new List<string>();
        List<string> minTempList = new List<string>();
        List<string> willItRainList = new List<string>();
        List<string> chanceOfRainList = new List<string>();
        List<string> overallConditionList = new List<string>();
        List<string> overallConditionUrlList = new List<string>();
        List<string> currentDayList = new List<string>();

        public ForecastData PopulateForecastData(string zipCode, int whichDate)
        {
            if(whichDate == 0) 
            {
                responseXml = callTheApi.CallApi_FutureForecast(zipCode);
            }

            GetNodeData("maxtemp_f", responseXml, "maxtemp", whichDate);
            forecastData.maxTemp = maxTempList[whichDate];
            GetNodeData("mintemp_f", responseXml, "mintemp", whichDate);
            forecastData.minTemp = minTempList[whichDate];
            GetNodeData("daily_will_it_rain", responseXml, "willitrain", whichDate);
            forecastData.willItRain = willItRainList[whichDate];
            GetNodeData("daily_chance_of_rain", responseXml, "chanceofrain", whichDate);
            forecastData.chanceOfRain = chanceOfRainList[whichDate];
            GetNodeData("condition/text", responseXml, "overallcondition", whichDate);
            forecastData.overallCondition = overallConditionList[whichDate];
            GetNodeData("condition/icon", responseXml, "overallconditionurl", whichDate);
            forecastData.overallConditionUrl = "https:"+overallConditionUrlList[whichDate];
            GetNodeData("", responseXml, "", whichDate);
            forecastData.currentDay = currentDayList[whichDate];

            return forecastData;
        }
        private void GetNodeData(string tagName, XmlDocument responseXml, string whichList, int date)
        {
            if(whichList == "maxtemp")
            {
                XmlNodeList xmlNodes = responseXml.SelectNodes("//forecast/forecastday/day/" + tagName);
                foreach (XmlNode xmlNode in xmlNodes)
                {
                    maxTempList.Add(xmlNode.InnerText);
                }
            }
            else if(whichList == "mintemp")
            {
                XmlNodeList xmlNodes = responseXml.SelectNodes("//forecast/forecastday/day/" + tagName);
                foreach (XmlNode xmlNode in xmlNodes)
                {
                    minTempList.Add(xmlNode.InnerText);
                }
            }
            else if(whichList == "willitrain")
            {
                XmlNodeList xmlNodes = responseXml.SelectNodes("//forecast/forecastday/day/" + tagName);
                foreach (XmlNode xmlNode in xmlNodes)
                {
                    willItRainList.Add(xmlNode.InnerText);
                }
            }
            else if (whichList == "chanceofrain")
            {
                XmlNodeList xmlNodes = responseXml.SelectNodes("//forecast/forecastday/day/" + tagName);
                foreach (XmlNode xmlNode in xmlNodes)
                {
                    chanceOfRainList.Add(xmlNode.InnerText);
                }
            }
            else if (whichList == "overallcondition")
            {
                XmlNodeList xmlNodes = responseXml.SelectNodes("//forecast/forecastday/day/" + tagName);
                foreach (XmlNode xmlNode in xmlNodes)
                {
                    overallConditionList.Add(xmlNode.InnerText);
                }
            }
            else if (whichList == "overallconditionurl")
            {
                XmlNodeList xmlNodes = responseXml.SelectNodes("//forecast/forecastday/day/" + tagName);
                foreach (XmlNode xmlNode in xmlNodes)
                {
                    overallConditionUrlList.Add(xmlNode.InnerText);
                }
            }
            else
            {
                int year = 0, month = 0, day = 0;
                XmlNodeList xmlNodes2 = responseXml.SelectNodes("//location/localtime");
                foreach (XmlNode xmlNode in xmlNodes2)
                {
                    year = int.Parse((xmlNode.InnerText).Substring(0, 4));
                    month = int.Parse((xmlNode.InnerText).Substring(5, 2));
                    day = int.Parse((xmlNode.InnerText).Substring(8, 2));
                }
                DateTime dateValue = new DateTime(year, month, day).AddDays(date);
                currentDayList.Add(dateValue.ToString("ddd"));
            }
        }
    }
}
