using Newtonsoft.Json;

namespace SubblySharp.Dto
{

    public partial class SubblyLineItemProduct
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("parent_id")] 
        public long ParentId { get; set; }

        [JsonProperty("type")] 
        public string Type { get; set; }

        [JsonProperty("gift_card")]
        public long GiftCard { get; set; }

        [JsonProperty("price")] 
        public string Price { get; set; }

        [JsonProperty("setup_fee")] 
        public string SetupFee { get; set; }

        [JsonProperty("shipping_fee")]
        public string ShippingFee { get; set; }

        [JsonProperty("shipping_fee_intl")] 
        public string ShippingFeeIntl { get; set; }

        [JsonProperty("funnel_id")]
        public string FunnelId { get; set; }

        [JsonProperty("created_on")] 
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("delivery_info")] 
        public object DeliveryInfo { get; set; }

        [JsonProperty("slug")] 
        public string Slug { get; set; }

        [JsonProperty("active")]
        public long? Active { get; set; }

        [JsonProperty("last_updated")] 
        public DateTimeOffset? LastUpdated { get; set; }

        [JsonProperty("archived")] 
        public long? Archived { get; set; }
    }
}
