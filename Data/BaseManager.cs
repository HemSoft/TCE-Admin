namespace HemSoft.TCE.Data
{
    using System.IO;
    using System.Net;
    using System.Text;

    using Newtonsoft.Json;

    public static class BaseManager
    {
        public static dynamic GetPage(string url, string offset = null)
        {
            if (offset != null)
            {
                url += "&offset=" + offset;
            }
            var myReq = WebRequest.Create(url);
            // TODO: Extract key to AppSecrets.config
            var credentials = Config.AirtableKey;
            var mycache = new CredentialCache();
            myReq.Headers.Add(credentials);
            var wr = myReq.GetResponse();
            var receiveStream = wr.GetResponseStream();
            var reader = new StreamReader(receiveStream, Encoding.UTF8);
            string content = reader.ReadToEnd();
            dynamic o = JsonConvert.DeserializeObject(content);
            return o;
        }
    }
}
