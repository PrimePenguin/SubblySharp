using Newtonsoft.Json;

namespace SubblySharp.Dto
{
    public class SubblyBaseFilter
    {
        [JsonProperty("page")] public int? Page { get; set; } = 1;

        [JsonProperty("per_page")] public int? PerPage { get; set; } = SubblyConsts.Limit;

        [JsonProperty("direction")] public string Direction { get; set; } = "desc";
    }
}
