using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class SubblyLineItem
    {

        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        [JsonProperty("item_price")]
        public string ItemPrice { get; set; }

        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        [JsonProperty("active")]
        public long Active { get; set; }

        [JsonProperty("origin")]
        public object Origin { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        public DateTimeOffset? UpdatedOn { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("product")]
        public SubblyLineItemProduct? Product { get; set; }
    }
}
