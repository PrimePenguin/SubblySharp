using System.Collections.Generic;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public  class SubblyProductsQuery
    {
        [JsonProperty("error")]
        public bool Error { get; set; }

        [JsonProperty("data")]
        public List<SubblyProduct> SubblyProducts { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}