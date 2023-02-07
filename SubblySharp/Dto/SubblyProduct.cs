using System;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public  class SubblyProduct
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("parent_id")]
        public string ParentId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("shop")]
        public long? Shop { get; set; }

        [JsonProperty("category")]
        public long? Category { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("setup_fee")]
        public string SetupFee { get; set; }

        [JsonProperty("shipping_fee")]
        public string ShippingFee { get; set; }

        [JsonProperty("shipping_fee_intl")]
        public string ShippingFeeIntl { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("delivery_info")]
        public string DeliveryInfo { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("frequency_unit")]
        public string FrequencyUnit { get; set; }

        [JsonProperty("frequency_count")]
        public int? FrequencyCount { get; set; }

        [JsonProperty("billing_frequency_type")]
        public string BillingFrequencyType { get; set; }

        [JsonProperty("delivery_frequency_type")]
        public string DeliveryFrequencyType { get; set; }

        [JsonProperty("active")]
        public long? Active { get; set; }

        [JsonProperty("last_updated")]
        public DateTimeOffset? LastUpdated { get; set; }

        [JsonProperty("stripe_plan_id")]
        public long? StripePlanId { get; set; }

        [JsonProperty("pre_order_end_at")]
        public DateTimeOffset? PreOrderEndAt { get; set; }

        [JsonProperty("gifting_enabled")]
        public long? GiftingEnabled { get; set; }

        [JsonProperty("archived")]
        public long? Archived { get; set; }

        [JsonProperty("commitment_billing_count")]
        public long? CommitmentBillingCount { get; set; }

        [JsonProperty("rebilling_start_at")]
        public DateTimeOffset? RebillingStartAt { get; set; }

        [JsonProperty("cut_off_at")]
        public DateTimeOffset? CutOffAt { get; set; }

        [JsonProperty("membership")]
        public long? Membership { get; set; }

        [JsonProperty("gift_card")]
        public long? GiftCard { get; set; }

        [JsonProperty("gift_card_expiration")]
        public long? GiftCardExpiration { get; set; }

        [JsonProperty("collect_shipping_address")]
        public long? CollectShippingAddress { get; set; }

        [JsonProperty("rebilling_date")]
        public DateTimeOffset? RebillingDate { get; set; }

        [JsonProperty("rebilling_months")]
        public long? RebillingMonths { get; set; }

        [JsonProperty("charge_immediately")]
        public string ChargeImmediately { get; set; }

        [JsonProperty("ship_immediately")]
        public long? ShipImmediately { get; set; }

        [JsonProperty("cut_off_date")]
        public DateTimeOffset? CutOffDate { get; set; }

        [JsonProperty("shipping_date")]
        public DateTimeOffset? ShippingDate { get; set; }

        [JsonProperty("tax_product_code")]
        public string TaxProductCode { get; set; }

        [JsonProperty("trial_price")]
        public string TrialPrice { get; set; }

        [JsonProperty("trial_length_days")]
        public long? TrialLengthDays { get; set; }

        [JsonProperty("from_price")]
        public string FromPrice { get; set; }

        [JsonProperty("images")]
        public ProductImage[] Images { get; set; }

        [JsonProperty("num_subscribers")]
        public long NumSubscribers { get; set; }

        [JsonProperty("pricing")]
        public ProductPricing[] Pricing { get; set; }

        [JsonProperty("variants")]
        public ProductVariant[] Variants { get; set; }

        [JsonProperty("stock_count")]
        public long StockCount { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("urls", NullValueHandling = NullValueHandling.Ignore)]
        public Urls Urls { get; set; }
    }

    public  class Urls
    {
        [JsonProperty("add_to_cart")]
        public Uri AddToCart { get; set; }

        [JsonProperty("checkout")]
        public Uri Checkout { get; set; }
    }
}
