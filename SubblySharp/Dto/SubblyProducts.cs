using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public  class SubblyProducts
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("data")]
        public SubblyProduct[] Data { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
