using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace WeatherAppUsingApi
{
    internal class LocationApiCall
    {
        Uri locationApiUri = new Uri("http://ip-api.com/xml/");
        XmlDocument responseXml = new XmlDocument();

        public string CallApiAndReturnZip()
        {
            string ipAddress = GetIpFromPc();
            var request = WebRequest.Create(locationApiUri + "?" + ipAddress) as HttpWebRequest;
            var response = request.GetResponse();

            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);

            var result = readStream.ReadToEnd();
            responseXml.LoadXml(result);
            string valueToReturn = "";

            XmlNodeList nodeList = responseXml.GetElementsByTagName("zip");
            foreach (XmlNode node in nodeList)
            {
                valueToReturn = node.InnerText;
            }
            return valueToReturn;
        }

        public string GetIpFromPc()
        {
            string hostName = Dns.GetHostName();
            Console.WriteLine(hostName);
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            return myIP;
        }
    }
}
