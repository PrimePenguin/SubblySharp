using System;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public  class SubscriptionModel
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("active")]
        public long? Active { get; set; }

        [JsonProperty("past_due")]
        public long? PastDue { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("cancelled_on")]
        public DateTimeOffset? CancelledOn { get; set; }

        [JsonProperty("gift")]
        public long? Gift { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("next_payment_date")]
        public DateTimeOffset? NextPaymentDate { get; set; }
    }
}