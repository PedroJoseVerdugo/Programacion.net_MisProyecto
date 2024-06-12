using System.Text.Json.Serialization;


public class CurrencyListResponse
{
    [JsonPropertyName("provider")]
    public string provider { get; set; }

    [JsonPropertyName("rates")]
    public Dictionary<string, decimal> rates { get; set; }
}

