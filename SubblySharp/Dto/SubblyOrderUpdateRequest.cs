using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class SubblyOrderUpdateRequest
    {
        [JsonProperty("id")]
        public string[] Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        [JsonProperty("carrier_service")]
        public string CarrierService { get; set; }

        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// Should be used when status = shipped In:0,1 - Default value: 0 
        /// </summary>
        [JsonProperty("dispatch_shipped_email")]
        public int? DispatchShippedEmail { get; set; }
    }
}