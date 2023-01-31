using System;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public  class SubblyOrderDetail
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("internal_id")]
        public long? InternalId { get; set; }

        [JsonProperty("status")]
        public long? Status { get; set; }

        [JsonProperty("status_name")]
        public string StatusName { get; set; }

        [JsonProperty("survey")]
        public SurveyModel Survey { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("due_date")]
        public DateTimeOffset? DueDate { get; set; }

        [JsonProperty("subtotal")]
        public string Subtotal { get; set; }

        [JsonProperty("total")]
        public string Total { get; set; }

        [JsonProperty("carrier")]
        public object Carrier { get; set; }

        [JsonProperty("carrier_service")]
        public object CarrierService { get; set; }

        [JsonProperty("tracking_number")]
        public object TrackingNumber { get; set; }

        [JsonProperty("shipping_cost")]
        public object ShippingCost { get; set; }

        [JsonProperty("updated_on")]
        public string UpdatedOn { get; set; }

        [JsonProperty("archived")]
        public long Archived { get; set; }

        [JsonProperty("is_gift")]
        public long IsGift { get; set; }

        [JsonProperty("tax_amount")]
        public string TaxAmount { get; set; }

        [JsonProperty("tax_rate")]
        public long TaxRate { get; set; }

        [JsonProperty("refunded")]
        public long Refunded { get; set; }

        [JsonProperty("refunded_amount")]
        public string RefundedAmount { get; set; }

        [JsonProperty("delivery_address")]
        public DeliveryAddressModel DeliveryAddress { get; set; }

        [JsonProperty("customer")]
        public SubblyCustomerModel Customer { get; set; }

        [JsonProperty("shop")]
        public SubblyShopModel Shop { get; set; }

        [JsonProperty("subscription")]
        public SubscriptionModel Subscription { get; set; }

        [JsonProperty("line_items")]
        public object[] LineItems { get; set; }

        [JsonProperty("tags")]
        public object[] Tags { get; set; }

        [JsonProperty("shipping_items")]
        public ShippingItemModel[] ShippingItems { get; set; }
    }
}
