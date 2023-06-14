using System;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public  class ProductPricing
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("setup_fee")]
        public string SetupFee { get; set; }

        [JsonProperty("rebilling_date")]
        public DateTimeOffset? RebillingDate { get; set; }

        [JsonProperty("rebilling_months")]
        public long? RebillingMonths { get; set; }

        [JsonProperty("cut_off_date")]
        public DateTimeOffset? CutOffDate { get; set; }

        [JsonProperty("shipping_date")]
        public DateTimeOffset? ShippingDate { get; set; }

        [JsonProperty("billing_frequency_type")]
        public long? BillingFrequencyType { get; set; }

        [JsonProperty("delivery_frequency_type")]
        public long? DeliveryFrequencyType { get; set; }

        [JsonProperty("shipping_fee")]
        public string ShippingFee { get; set; }

        [JsonProperty("shipping_fee_intl")]
        public string ShippingFeeIntl { get; set; }

        [JsonProperty("trial_length_days")]
        public long? TrialLengthDays { get; set; }

        [JsonProperty("trial_price")]
        public string TrialPrice { get; set; }

        [JsonProperty("stripe_plan_id")]
        public string StripePlanId { get; set; }

        [JsonProperty("charge_immediately")]
        public long? ChargeImmediately { get; set; }

        [JsonProperty("commitment_billing_count")]
        public long? CommitmentBillingCount { get; set; }

        [JsonProperty("urls")]
        public Urls Urls { get; set; }

        [JsonProperty("from_price")]
        public string FromPrice { get; set; }

        [JsonProperty("num_subscribers")]
        public long? NumSubscribers { get; set; }

        [JsonProperty("billing_frequency")]
        public BillingFrequency BillingFrequency { get; set; }

        [JsonProperty("delivery_frequency")]
        public DeliveryFrequency DeliveryFrequency { get; set; }

        [JsonProperty("stock_count")]
        public long? StockCount { get; set; }
    }

    public  class BillingFrequency
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stripe_interval")]
        public string StripeInterval { get; set; }

        [JsonProperty("stripe_count")]
        public long StripeCount { get; set; }
    }
    public  class DeliveryFrequency
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
