using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileMedico.Helper
{
    public class TwilioHelper
    {
        public static string Identity { get; private set; }

        public static async Task<string> GetTokenAsync()
        {

            var id  = Android.OS.Build.Serial.ToString();

          

            var http = new HttpClient();
            var data = await http.GetStringAsync("");

            var response = Newtonsoft.Json.JsonConvert.DeserializeObject<TwilioResponse>(data);

            Identity = response.Identity?.Trim('"') ?? string.Empty;

            return response?.Token?.Trim('"') ?? string.Empty;
        }
    }

    public class TwilioResponse
    {
        [Newtonsoft.Json.JsonProperty("identity")]
        public string Identity { get; set; } = string.Empty;

        [Newtonsoft.Json.JsonProperty("token")]
        public string Token { get; set; } = string.Empty;
    }
}
