﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace WeatherAppUsingApi
{
    internal class WeatherApiCall
    {
        string apiKey = ConfigurationManager.AppSettings.Get("apiKey");
        Uri weatherApiUri = new Uri("http://api.weatherapi.com/v1/");
        XmlDocument responseXml = new XmlDocument();

        public XmlDocument CallApi_CurrentWeather(string zipCode)
        {
            try
            {
                var request = WebRequest.Create(weatherApiUri + "current.xml?" + "key=" + apiKey + "&q=" + zipCode) as HttpWebRequest;
                var response = request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                var result = readStream.ReadToEnd();
                responseXml.LoadXml(result);
            }
            catch
            {
                MessageBox.Show("Something went wrong", "Uh oh!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return responseXml;
        }

        public XmlDocument CallApi_FutureForecast(string zipCode)
        {
            try
            {
                var request = WebRequest.Create(weatherApiUri + "forecast.xml?" + "key=" + apiKey + "&q=" + zipCode + "&days=3&aqi=yes") as HttpWebRequest;
                var response = request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                var result = readStream.ReadToEnd();
                responseXml.LoadXml(result);
            }
            catch
            {
                MessageBox.Show("Something went wrong", "Uh oh!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return responseXml;
        }

        public XmlDocument CallApi_GetMidnightForecast(string zipCode, string date)
        {
            try
            {
                var request = WebRequest.Create(weatherApiUri + "forecast.xml?" + "key=" + apiKey + "&date=" + date + "&hour=0" + "&q=" + zipCode) as HttpWebRequest;
                var response = request.GetResponse();
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

                var result = readStream.ReadToEnd();
                responseXml.LoadXml(result);
            }
            catch
            {
                MessageBox.Show("Something went wrong", "Uh oh!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return responseXml;
        }
    }
}
