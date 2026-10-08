using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace ConsoleApp1.APIHandler
{
    public class APIHandler
    {
        private readonly HttpClient httpClient = new HttpClient();

        public async Task<KeyValuePair<int,string>> GetAsync(string url)
        {
            HttpResponseMessage response = await httpClient.GetAsync(url);

            string result = await response.Content.ReadAsStringAsync();

            int statusCode = (int)response.StatusCode;

            return new KeyValuePair<int, string>(statusCode, result);
        }

        public async Task<KeyValuePair<int, string>> PostAsync(string url, object data)
        {
            string json = JsonSerializer.Serialize(data);

            StringContent content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
                );

            HttpResponseMessage response = await httpClient.PostAsync(url, content, CancellationToken.None);


            string result = await response.Content.ReadAsStringAsync();

            int statusCode = (int)response.StatusCode;

            return new KeyValuePair<int, string>(statusCode, result);
        }
    }
}