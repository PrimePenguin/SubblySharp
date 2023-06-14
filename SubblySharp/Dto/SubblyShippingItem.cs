using Newtonsoft.Json;
using System;

namespace SubblySharp.Dto
{
    public  class ShippingItem
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
        public string DeletedOn { get; set; }

        [JsonProperty("item")]
        public Item Item { get; set; }
    }

    public  class Item
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("photo_url")]
        public string PhotoUrl { get; set; }

        [JsonProperty("buy_price")]
        public decimal? BuyPrice { get; set; }

        [JsonProperty("sell_price")]
        public decimal? SellPrice { get; set; }

        [JsonProperty("stock_count")]
        public long? StockCount { get; set; }

        [JsonProperty("status")]
        public long? Status { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        public DateTimeOffset? UpdatedOn { get; set; }

        [JsonProperty("width")]
        public string Width { get; set; }

        [JsonProperty("height")]
        public string Height { get; set; }

        [JsonProperty("depth")]
        public string Depth { get; set; }

        [JsonProperty("weight")]
        public string Weight { get; set; }
    }
}
