using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace YouWeesh.Mobile.SAL
{
    public class HttpRequester
    {
        private string request;
        private string contentType;
        private string method;
        private string rxcui;

        public string Request
        {
            get
            {
                return request;
            }

            set
            {
                request = value;
            }
        }
        public string ContentType
        {
            get
            {
                return contentType;
            }

            set
            {
                contentType = value;
            }
        }
        public string Method
        {
            get
            {
                return method;
            }

            set
            {
                method = value;
            }
        }
        public string Rxcui
        {
            get
            {
                return rxcui;
            }

            set
            {
                rxcui = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>json String</returns>
        public string CallService()
        {/*
            var httpRequest = HttpWebRequest.Create(string.Format(this.request, this.rxcui));
            using (HttpWebResponse response = httpRequest.GetResponse() as HttpWebResponse)
            {
                if (response.StatusCode != HttpStatusCode.OK)
                    Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    var content = reader.ReadToEnd();
                    if (string.IsNullOrWhiteSpace(content))
                    {
                        return null;
                    }
                    else
                    {
                        return content;
                    }

                    //Assert.NotNull(content);
                }
            }*/
            return "1";
        }
    }
}
