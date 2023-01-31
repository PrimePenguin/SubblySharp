using Newtonsoft.Json;

namespace SubblySharp.Filters
{
    public class SubblyFilter 
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

        [JsonProperty("page")]
        public int? Page { get; set; }

        [JsonProperty("per_page")]
        public int? PerPage { get; set; }

        [JsonProperty("direction")]
        public string Direction { get; set; }

        [JsonProperty("order_by")]
        public string OrderBy { get; set; }

    }
}
