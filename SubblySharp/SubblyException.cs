using Newtonsoft.Json;
using System;
using System.Net;

namespace SubblySharp
{
    public class SubblyException : Exception
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("errors")]
        public Errors Errors { get; set; }

        public string ApiResponse { get; set; }

        public HttpStatusCode StatusCode { get; set; }
    }

    public class Errors
    {
        [JsonProperty("status")]
        public string[] Status { get; set; }
    }
}
