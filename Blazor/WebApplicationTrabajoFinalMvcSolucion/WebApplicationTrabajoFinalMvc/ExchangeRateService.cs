using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

public class ExchangeRateService
{
    private readonly HttpClient _httpClient;

    public ExchangeRateService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<decimal> GetExchangeRateAsync(string fromCurrency, string toCurrency)
    {
        var response = await _httpClient.GetStringAsync($"https://api.exchangerate-api.com/v4/latest/{fromCurrency}");
        var data = JObject.Parse(response);
        var rate = data["rates"][toCurrency].Value<decimal>();
        return rate;
    }
}

