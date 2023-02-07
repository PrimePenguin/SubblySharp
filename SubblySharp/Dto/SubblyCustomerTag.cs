using System;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class SubblyCustomerTag
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("updated_on")]
        public DateTimeOffset? UpdatedOn { get; set; }

        [JsonProperty("pivot")]
        public CustomerTagPivot Pivot { get; set; }
    }

    public class CustomerTagPivot
    {
        [JsonProperty("customer_id")]
        public long? CustomerId { get; set; }

        [JsonProperty("tag_id")]
        public long? TagId { get; set; }
    }
}
