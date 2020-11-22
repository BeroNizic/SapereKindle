using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SapereKindle
{
    public class AzureProvider
    {
        public AzureServiceCredentials Credentials { get; set; }        

        public AzureProvider()
        {
            var json = File.ReadAllText("azure_translation_subscription.json");
            Credentials = JsonConvert.DeserializeObject<AzureServiceCredentials>(json);
        }

        private async Task<string> ExecuteApiCallAsync(string route, object[] body)
        {
            string result = "";
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage())
            {
                // Build the request.
                request.Method = HttpMethod.Post;
                request.RequestUri = new Uri(Credentials.EndPoint + route);
                var requestBody = JsonConvert.SerializeObject(body);
                request.Content = new StringContent(requestBody, Encoding.UTF8, "application/json");
                request.Headers.Add("Ocp-Apim-Subscription-Key", Credentials.SubscriptionKey);
                request.Headers.Add("Ocp-Apim-Subscription-Region", Credentials.Location);

                // Send the request and get response.
                HttpResponseMessage response = await client.SendAsync(request).ConfigureAwait(false);
                // Read response as a string.
                result = await response.Content.ReadAsStringAsync();
            }
            return result;
        }

        public async Task<string> TranslateAzureAsync(string text, string fromLang, string toLang)
        {
            // Input and output languages are defined as parameters.
            string route = $"/translate?api-version=3.0&from={fromLang}&to={toLang}";
            object[] body = new object[] { new { Text = text } };
            var response = await ExecuteApiCallAsync(route, body).ConfigureAwait(false);
            Root obj = JsonConvert.DeserializeObject<Root>(response);
            return obj[0].Translations[0].Text;
        }

        private class Translation
        {
            public string Text { get; set; }
            public string To { get; set; }
        }

        private class MyArray
        {
            public List<Translation> Translations { get; set; }
        }

        private class Root : List<MyArray>
        {            
        }
    }
}
