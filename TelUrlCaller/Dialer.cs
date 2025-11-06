using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelUrlCaller
{
    public static class Dialer
    {
        public static async Task<HttpResponseMessage> Call(string number)
        {
            using HttpClient client = new();

            string requestUri = Properties.Settings.Default.ActionUri.Replace("{number}", Uri.EscapeDataString(number));

            HttpResponseMessage res = await client.GetAsync(requestUri);
            return res;
        }
    }
}
