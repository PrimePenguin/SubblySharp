using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public  class SubblyShopModel
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("country")]
        public CountryModel Country { get; set; }
    }

    public partial class CountryModel
    {
        [JsonProperty("id")]
        public long? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("currency_name")]
        public string CurrencyName { get; set; }

        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }

        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }

        [JsonProperty("currency_html")]
        public string CurrencyHtml { get; set; }

        [JsonProperty("status")]
        public long? Status { get; set; }
    }
}
