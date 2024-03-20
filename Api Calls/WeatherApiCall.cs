using System;
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

        public XmlDocument CallApi(string zipCode)
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
    }
}
