using System;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class SubblyOrder
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("internal_id")]
        public string InternalId { get; set; }

        [JsonProperty("customer_order_number")]
        public long? CustomerOrderNumber { get; set; }

        [JsonProperty("subscription_order_number")]
        public string SubscriptionOrderNumber { get; set; }

        [JsonProperty("status")]
        public long? Status { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("survey")]
        public string Survey { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("due_date")]
        public DateTimeOffset? DueDate { get; set; }

        [JsonProperty("subtotal")]
        public long? Subtotal { get; set; }

        [JsonProperty("total")]
        public long? Total { get; set; }

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
        public long? TaxAmount { get; set; }

        [JsonProperty("tax_rate")]
        public long? TaxRate { get; set; }

        [JsonProperty("disputed")]
        public long? Disputed { get; set; }

        [JsonProperty("refunded")]
        public long? Refunded { get; set; }

        [JsonProperty("refunded_amount")]
        public long? RefundedAmount { get; set; }

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
        public SubblyLineItem[] LineItems { get; set; }

        [JsonProperty("tags")]
        public OrderTagModel[] Tags { get; set; }

        [JsonProperty("shipping_items")]
        public object[] ShippingItems { get; set; }

        [JsonProperty("shipping_info")]
        public ShippingInfo ShippingInfo { get; set; }
    }
}
