using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public  class ProductVariant
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("parent_id")]
        public long? ParentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("stock_count")]
        public long? StockCount { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }

        [JsonProperty("from_price")]
        public string FromPrice { get; set; }

        [JsonProperty("images")]
        public ProductImage[] Images { get; set; }

        [JsonProperty("options")]
        public Option[] Options { get; set; }

        [JsonProperty("gift_card", NullValueHandling = NullValueHandling.Ignore)]
        public long? GiftCard { get; set; }

        [JsonProperty("gift_card_expiration")]
        public long? GiftCardExpiration { get; set; }
    }

    public class Option
    {
        [JsonProperty("id")] 
        public long? Id { get; set; }

        [JsonProperty("name")] 
        public string Name { get; set; }

        [JsonProperty("value")] 
        public string Value { get; set; }
    }
}

