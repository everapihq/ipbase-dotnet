using System.IO;
using System.Net;

namespace ipbase.Helpers
{
    public class RequestHelper
    {
        public const string BaseUrl = "https://api.ipbase.com/v2/";

        public RequestHelper()
        {
        }

        public static string Status(string apiKey = null)
        {
            string url;
            url = BaseUrl + "/status?apikey=" + apiKey;

            return GetResponse(url);
        }

        public static string Info(string apiKey, string ip, string language = "")
        {
            string url;
            url = BaseUrl + "/info?ip="+ ip +"&language=" + language + "&apikey=" + apiKey;

            return GetResponse(url);
        }

        private static string GetResponse(string url)
        {
            string jsonString;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (var response = (HttpWebResponse)request.GetResponse())
            using (var stream = response.GetResponseStream())
            using (var reader = new StreamReader(stream))
            {
                jsonString = reader.ReadToEnd();
            }

            return jsonString;
        }
    }
}

