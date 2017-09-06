using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace WebHookster
{
    public static class WHHttpClient
    {
        static HttpClient _httpClient = new HttpClient();

        public  static async Task PostAsync(string payloadJson, Uri _uri)
        {
            try
            {
                Console.WriteLine(payloadJson);
                var content = new StringContent(payloadJson, Encoding.UTF8, "application/json");
                var result = await _httpClient.PostAsync(_uri, content);
                Console.WriteLine(result.StatusCode);
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc.Message);
                Console.WriteLine(exc.InnerException);
            }
        }
    }
}
