using System;
using ipbase.Helpers;

namespace ipbase
{
    public class Ipbase
    {
        private string ApiKey { get; }

        public Ipbase()
        {
        }

        public Ipbase(string apiKey)
        {
            ApiKey = apiKey;
        }

        public string Status()
        {
            return RequestHelper.Status(ApiKey);
        }

        public string Info(string ip, string language)
        {
            return RequestHelper.Info(ApiKey, ip, language);
        }
    }
}

