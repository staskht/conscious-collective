using System.Text.Json.Serialization;

namespace ServiceContracts.DTOs
{
    public class WikiRateAnswerDto
    {
        [JsonPropertyName("company")]
        public string? Company {  get; set; }
        [JsonPropertyName("value")]
        public double Value { get; set; }

    }
}
