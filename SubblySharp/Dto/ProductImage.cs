using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class ProductImage
    {
        [JsonProperty("id")] 
        public long? Id { get; set; }

        [JsonProperty("product")] 
        public long? Product { get; set; }

        [JsonProperty("url")] 
        public Uri Url { get; set; }

        [JsonProperty("guid")] 
        public string Guid { get; set; }

        [JsonProperty("name")] 
        public string Name { get; set; }

        [JsonProperty("deleted")] 
        public long? Deleted { get; set; }

        [JsonProperty("order")] 
        public long? Order { get; set; }

        [JsonProperty("created_on")] 
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("updated_on")] 
        public DateTimeOffset? UpdatedOn { get; set; }

        [JsonProperty("original_url")] 
        public Uri OriginalUrl { get; set; }
    }

}
