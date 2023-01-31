using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public  class ShippingInfo
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("method")]
        public Method Method { get; set; }
    }

    public  class Method
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("rule_id")]
        public long? RuleId { get; set; }

        [JsonProperty("rule_name")]
        public string RuleName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("duration")]
        public long? Duration { get; set; }

        [JsonProperty("price")]
        public long? Price { get; set; }

        [JsonProperty("option_type")]
        public string OptionType { get; set; }

        [JsonProperty("aggregated_price_type")]
        public string AggregatedPriceType { get; set; }
    }
}
