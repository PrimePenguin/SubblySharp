using System;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{   
    public class SubblyFilter : SubblyBaseFilter
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("start_created_on")]
        public DateTimeOffset? StartCreatedOn { get; set; }

        [JsonProperty("end_created_on")]
        public DateTimeOffset? EndCreatedOn { get; set; }

        [JsonProperty("start_due_date")]
        public DateTimeOffset? StartDueDate { get; set; }

        [JsonProperty("end_due_date")]
        public DateTimeOffset? EndDueDate { get; set; }

        [JsonProperty("order_by")]
        public string OrderBy { get; set; }

    }
}
