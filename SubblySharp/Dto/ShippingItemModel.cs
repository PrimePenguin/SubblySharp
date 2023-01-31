using System;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class ShippingItemModel
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("order_id")]
        public long? OrderId { get; set; }

        [JsonProperty("inventory_item_id")]
        public long? InventoryItemId { get; set; }

        [JsonProperty("quantity")]
        public long? Quantity { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        public DateTimeOffset? UpdatedOn { get; set; }

        [JsonProperty("deleted_on")]
        public DateTimeOffset? DeletedOn { get; set; }

        [JsonProperty("item")]
        public SubblyItemModel Item { get; set; }
    }
}
