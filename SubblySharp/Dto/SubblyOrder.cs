using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class SubblyOrder
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("internal_id")]
        public string InternalId { get; set; }

        [JsonProperty("customer_order_number")]
        public string CustomerOrderNumber { get; set; }

        [JsonProperty("subscription_order_number")]
        public string SubscriptionOrderNumber { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("survey")]
        public string Survey { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("due_date")]
        public DateTimeOffset? DueDate { get; set; }

        [JsonProperty("subtotal")]
        public decimal? Subtotal { get; set; }

        [JsonProperty("total")]
        public decimal? Total { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("carrier_service")]
        public string CarrierService { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        [JsonProperty("shipping_cost")]
        public string ShippingCost { get; set; }

        [JsonProperty("updated_on")]
        public DateTimeOffset? UpdatedOn { get; set; }

        [JsonProperty("archived")]
        public long? Archived { get; set; }

        [JsonProperty("is_gift")]
        public long? IsGift { get; set; }

        [JsonProperty("gift_message")]
        public string GiftMessage { get; set; }

        [JsonProperty("tax_amount")]
        public decimal? TaxAmount { get; set; }

        [JsonProperty("tax_rate")]
        public decimal? TaxRate { get; set; }

        [JsonProperty("disputed")]
        public long? Disputed { get; set; }

        [JsonProperty("refunded")]
        public long? Refunded { get; set; }

        [JsonProperty("refunded_amount")]
        public decimal? RefundedAmount { get; set; }

        [JsonProperty("exchange_rate")]
        public long? ExchangeRate { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("base_currency_code")]
        public string BaseCurrencyCode { get; set; }

        [JsonProperty("delivery_address")]
        public DeliveryAddressModel DeliveryAddress { get; set; }

        [JsonProperty("customer")]
        public SubblyCustomerModel Customer { get; set; }

        [JsonProperty("shop")]
        public SubblyShopModel Shop { get; set; }

        [JsonProperty("subscription")]
        public SubscriptionModel Subscription { get; set; }

        [JsonProperty("line_items")]
        public List<SubblyLineItem> LineItems { get; set; }

        [JsonProperty("tags")]
        public OrderTagModel[] Tags { get; set; }

        [JsonProperty("shipping_items")]
        public ShippingItem[] ShippingItems { get; set; }

        [JsonProperty("shipping_info")]
        public ShippingInfo ShippingInfo { get; set; }
    }

    public class SubblyLineItem
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("order_id")]
        public string OrderId { get; set; }

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
        public SubblyLineItemProduct Product { get; set; }
    }

    public class SubblyLineItemProduct
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

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
