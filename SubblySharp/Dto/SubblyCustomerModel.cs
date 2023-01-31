using System;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public partial class SubblyCustomerModel
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("marketing_consent")]
        public long? MarketingConsent { get; set; }

        [JsonProperty("user")]
        public SubblyUser User { get; set; }
    }
}
