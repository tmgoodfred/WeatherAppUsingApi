using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using static System.Net.WebRequestMethods;

namespace WeatherAppUsingApi
{
    public partial class WeatherMainPage : Form
    {
        string apiKey = ConfigurationManager.AppSettings.Get("apiKey");
        Uri weatherApiUri = new Uri("http://api.weatherapi.com/v1/");
        string zipCode = "75002";
        static HttpClient client = new HttpClient();
        XmlDocument responseXml = new XmlDocument();

        public WeatherMainPage()
        {
            InitializeComponent();
        }

        private void getTempBtn_Click(object sender, EventArgs e)
        {
            var request = WebRequest.Create(weatherApiUri + "current.xml?" + "key=" + apiKey + "&q=" + zipCode) as HttpWebRequest;
            var response = request.GetResponse();

            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            var result = readStream.ReadToEnd();

            responseXml.LoadXml(result);

            XmlNodeList nodeList = responseXml.GetElementsByTagName("temp_f");
            foreach (XmlNode node in nodeList)
            {
                tempTxt.Text = node.InnerText;
            }

            XmlNodeList nodeList2 = responseXml.GetElementsByTagName("icon");
            foreach (XmlNode node in nodeList2)
            {
                string iconLink = node.InnerText;
                iconImg.ImageLocation = iconLink;
            }

            XmlNodeList nodeList3 = responseXml.GetElementsByTagName("wind_mph");
            foreach (XmlNode node in nodeList3)
            {
                string windspeed = node.InnerText;
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
}
