using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using FinalTrabajo.Models;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FinalTrabajo.Services
{
    public class ConversorMonedaConverterService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "f8c975868ee6a437db59716d";

        public ConversorMonedaConverterService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<decimal> ConvertCurrency(decimal amount, string fromCurrency, string toCurrency)
        {
            var requestUrl = $"https://v6.exchangerate-api.com/v6/{_apiKey}/pair/{fromCurrency}/{toCurrency}/{amount}";

            var response = await _httpClient.GetAsync(requestUrl);
            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var conversionResult = System.Text.Json.JsonSerializer.Deserialize<ConversionResponse>(jsonResponse);
                return conversionResult.ConversionRate * amount;
            }
            else
            {
                throw new Exception("Error al obtener la tasa de conversión.");
            }
        }

        public async Task<List<string>> GetCurrencyList()
        {
            var response = await _httpClient.GetAsync("https://api.exchangerate-api.com/v4/latest/USD");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var currencyListResponse = System.Text.Json.JsonSerializer.Deserialize<ConversorMonedaListResponse>(content);
                var currencyCodes = currencyListResponse.rates.Keys.ToList();
                return currencyCodes;
            }

            return new List<string>();
        }

    }
}
