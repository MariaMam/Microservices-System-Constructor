using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace APIGateway.Requests
{
    public class ModuleConfigRequests
  {
        static string Url = "http://localhost:62748/api/moduleconfiguration";


        public static async Task<string> GetAll()
        {
            var client = new HttpClient();
            /*client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(Url));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");*/

            return await client.GetStringAsync(Url);        
            
        }

        public static async Task<string> GetModuleConfigByModule(string module, string version)
        {
            var client = new HttpClient();
            /*client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(Url));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");*/

            return await client.GetStringAsync(Url+ "/GetByModule?module=" + module+"&"+version);

        }
    }
}
