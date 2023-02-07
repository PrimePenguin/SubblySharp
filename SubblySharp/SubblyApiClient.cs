using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace SubblySharp
{
    public class SubblyApiClient
    {
        public string BaseUri;
        public string AccessToken;

        public SubblyApiClient(string baseUri, string accessToken)
        {
            BaseUri = baseUri;
            AccessToken = accessToken;
        }

        public async Task<T> ExecuteAsync<T>(HttpMethod method, string requestUrl, object data = null)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {AccessToken}");
                var requestMessage = new HttpRequestMessage(method, $"{BaseUri}{requestUrl}");

                if (data != null)
                {
                    var json = JsonConvert.SerializeObject(data, Formatting.None, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });
                    requestMessage.Content = new StringContent(json, Encoding.UTF8, "application/json");
                }

                var response = await client.SendAsync(requestMessage);
                var result = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    var exception = JsonConvert.DeserializeObject<SubblyException>(result);
                    exception.Message = result;
                    throw (SystemException) exception;
                }

                var responseObj = JsonConvert.DeserializeObject<T>(result);
                return responseObj;

            }
        }
    }
}
