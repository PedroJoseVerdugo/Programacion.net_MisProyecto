using System.Text.Json.Serialization;
using FinalTrabajo.Services;

public class ConversorMonedaListResponse
{
    [JsonPropertyName("rates")]
    public Dictionary<string, decimal> rates { get; set; }
}
