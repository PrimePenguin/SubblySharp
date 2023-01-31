using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class SubblyOrders
    {
        [JsonProperty("data")]
        public SubblyOrder[] Data { get; set; }

        [JsonProperty("current_page")]
        public long CurrentPage { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("first")]
        public long First { get; set; }

        [JsonProperty("last")]
        public long Last { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

    }
}
