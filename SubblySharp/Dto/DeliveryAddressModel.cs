using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class DeliveryAddressModel
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("address_1")]
        public string Address1 { get; set; }

        [JsonProperty("address_2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("default")]
        public long? Default { get; set; }

        [JsonProperty("region_code")]
        public string RegionCode { get; set; }
    }
}
