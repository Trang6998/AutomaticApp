using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomationQlahsVksndtcWindowsFormsApp.Resources
{
    class JsonDataFromWs 
    {
        private static JsonDataFromWs _instance;
        static JObject json;
        static string id;
        private JsonDataFromWs()
        {
            new Action(async () => await GetDataAsync())();

            //var path = Application.StartupPath + "/jsonFinish.txt";
            //string urlText = File.ReadAllText(path, Encoding.UTF8);
            //json = JObject.Parse(urlText);
        }
        async Task GetDataAsync()
        {
            string url = ("http://qlahstt.vkshanoi.gov.vn:8899/api/hosoanhinhsu/dientudong?hoSoAnHinhSuID=" + id);
        //http://qlahstt.vkshanoi.gov.vn:8899/api/hosoanhinhsu/dientudong?hoSoAnHinhSuID=1066

            WebRequest request = HttpWebRequest.Create(url);
            using (WebResponse response = request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string urlText = reader.ReadToEnd();
                    json = JObject.Parse(urlText);
                }
            }
        }

        public static JsonDataFromWs Instance(string _id)
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.
            id = _id;
            if (_instance == null)
            {
                _instance = new JsonDataFromWs();
            }
            
            return _instance;
        }

        internal static object Instance(object id)
        {
            throw new NotImplementedException();
        }

        public JObject get()
        {
            return json;
        }
    }
}
