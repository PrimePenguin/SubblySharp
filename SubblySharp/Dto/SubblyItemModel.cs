using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class SubblyItemModel
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("sku")]
        public long? Sku { get; set; }

        [JsonProperty("inventory_item_group_id")]
        public long? InventoryItemGroupId { get; set; }

        [JsonProperty("shop_id")]
        public long? ShopId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("buy_price")]
        public string BuyPrice { get; set; }

        [JsonProperty("sell_price")]
        public string SellPrice { get; set; }

        [JsonProperty("stock_count")]
        public long? StockCount { get; set; }

        [JsonProperty("status")]
        public long? Status { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        public DateTimeOffset? UpdatedOn { get; set; }

        [JsonProperty("deleted_on")]
        public DateTimeOffset? DeletedOn { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("depth")]
        public int? Depth { get; set; }

        [JsonProperty("weight")]
        public int? Weight { get; set; }
    }
}
