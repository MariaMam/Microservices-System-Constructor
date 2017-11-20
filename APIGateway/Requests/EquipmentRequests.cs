using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace APIGateway.Requests
{
    public class EquipmentRequests
    {
        static string Url = "http://localhost:61944/api/equipment";


        public static async Task<string> GetAllEquipment()
        {
            var client = new HttpClient();
            /*client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(Url));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");*/

            return await client.GetStringAsync(Url);        
            
        }

        public static async Task<string> Get(Guid id)
        {
            var client = new HttpClient();
            /*client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue(Url));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");*/

            return await client.GetStringAsync(Url+"/"+id);

        }
    }
}
