using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bosch2VMix
{
    class VMixWrapper
    {
        private string host;
        private string port;
        private string xmlStr;
        public static XmlDocument doc = new XmlDocument();


        public VMixWrapper()
        {
            
        }

        public VMixWrapper(string host = "127.0.0.1", string port = "8088")
        {
            Console.WriteLine("Created VMixWrapper");
            this.UpdateHost(host, port);
            
        }

        public void UpdateXml()
        {
            try
            {
                doc.LoadXml(xmlStr);
                Console.WriteLine(doc.OuterXml);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: "+e.Message);
                Console.WriteLine(e.InnerException.InnerException.Message);
            }

        }

        public async Task GetXml(Uri uri)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(uri);
                    string xmlRaw = await response.Content.ReadAsStringAsync();
                    if (!string.Equals(xmlRaw, this.xmlStr))
                    { 
                        Console.WriteLine("Xml updated");
                        this.xmlStr = xmlRaw;
                    }

                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.InnerException.InnerException.Message);
                }
            }

        }

        public void UpdateHost(string host = "127.0.0.1", string port = "8088")
        {
            this.host = host;
            this.port = port;

            Console.WriteLine("Host = " + this.host);
            Console.WriteLine("Port = " + this.port);
        }

        public Uri GetUri()
        {
            UriBuilder vmixUri = new UriBuilder("http", this.host, int.Parse(port), "/api");
            Console.WriteLine("VMix URI = " + vmixUri.Uri.AbsoluteUri);
            return vmixUri.Uri;
        }
    }
}
