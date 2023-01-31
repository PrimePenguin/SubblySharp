using Newtonsoft.Json;

namespace SubblySharp
{
    public  class SubblyResponse
    {
        [JsonProperty("message")]
        public string Message { get; set; }
    }

}
