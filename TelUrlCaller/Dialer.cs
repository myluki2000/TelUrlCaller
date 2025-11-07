using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace TelUrlCaller
{
    public static class Dialer
    {
        public static async Task<HttpResponseMessage> Call(string number, string username, string password)
        {
            using HttpClient client = new();

            string requestUri = Properties.Settings.Default.ActionUri.Replace("{number}", Uri.EscapeDataString(number));

            HttpRequestMessage req = new(HttpMethod.Get, requestUri);
            req.Headers.Authorization =
                new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes(
               $"{username}:{password}")));

            HttpResponseMessage res = await client.SendAsync(req);
            return res;
        }
    }
}
