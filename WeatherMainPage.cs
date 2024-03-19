using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using System.Xml;

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
        }
    }
}
