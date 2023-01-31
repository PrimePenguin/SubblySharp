using System;
using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class SubblyUser
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("created_on")]
        public DateTimeOffset? CreatedOn { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }
    }
}
