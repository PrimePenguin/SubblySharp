using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class SubblyOrderProduct
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("parent_id")]
        public long? ParentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("setup_fee")]
        public string SetupFee { get; set; }

        [JsonProperty("shipping_fee")]
        public string ShippingFee { get; set; }

        [JsonProperty("shipping_fee_intl")]
        public string ShippingFeeIntl { get; set; }

        [JsonProperty("created_on")]
        public long? CreatedOn { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("delivery_info")]
        public string DeliveryInfo { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("active")]
        public long? Active { get; set; }

        [JsonProperty("last_updated")]
        public long? LastUpdated { get; set; }

        [JsonProperty("archived")]
        public long? Archived { get; set; }
    }
}
