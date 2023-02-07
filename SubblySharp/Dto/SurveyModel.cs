using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class SurveyModel
    {
        [JsonProperty("version")]
        public long? Version { get; set; }

        [JsonProperty("survey_id")]
        public long? SurveyId { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonProperty("questions")]
        public Question[] Questions { get; set; }
    }

    public class Question
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Answer
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("price_modifier")]
        public long? PriceModifier { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public long? Quantity { get; set; }
    }
}
