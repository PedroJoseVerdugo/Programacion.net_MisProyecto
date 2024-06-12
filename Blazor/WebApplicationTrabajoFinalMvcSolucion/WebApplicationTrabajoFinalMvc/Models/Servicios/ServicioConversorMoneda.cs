
namespace WebApplicationTrabajoFinalMvc.Models.Servicios
{
    public class ServicioConversionMoneda
    {


        // Crear un campo para guardar el HttpClient

        private readonly HttpClient _httpClient;

        // Guardar el ApiKey

        private readonly string _apiKey = "84e0d8faa9cad370fff5df88";
        private static ExchangeRates? exchangeRates;

        public ServicioConversionMoneda(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<List<string>> ObtenerMonedas()
        {
            // Llamar al servicio que obtiene las monedas
            var respuesta = await _httpClient.GetAsync("https://api.exchangerate-api.com/v4/latest/EUR");

            // Variable para almacenar el resultado
            var contenidoJson = "";

            // Comprobar que todo ha ido bien
            if (respuesta.IsSuccessStatusCode)
            {

                // Obtener el json
                contenidoJson = await respuesta.Content.ReadAsStringAsync();

                // Convertir el json a un objeto
                var ObjetoMonedas = System.Text.Json.JsonSerializer.Deserialize<CurrencyListResponse>(contenidoJson);

                // Obtener la lista de monedas
                var monedas = ObjetoMonedas.rates.Keys.ToList();


                return monedas;

            }

            return new List<string>();

        }

        public async Task<string> Conversion(string origen, string destino, string importe)
        {
            string apiKey = "84e0d8faa9cad370fff5df88";
            string apiUrl = $"https://open.er-api.com/v6/latest/{origen}?apikey={apiKey}";
            double res = 0;
            double double_importe = double.Parse(importe);
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    exchangeRates = Newtonsoft.Json.JsonConvert.DeserializeObject<ExchangeRates>(responseBody);
                    if (exchangeRates != null && exchangeRates.Rates.ContainsKey(destino))
                    {
                        res = double_importe * exchangeRates.Rates[destino];
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron tasas de cambio para la moneda de destino.");
                    }
                }
                catch (HttpRequestException e)
                {
                    Console.WriteLine($"Error al realizar la solicitud HTTP: {e.Message}");
                }
            }
            return res.ToString();
        }

    }
    public class ExchangeRates
    {
        public string Base
        {
            get;
            set;
        }
        public DateTime Date
        {
            get;
            set;
        }
        public System.Collections.Generic.Dictionary<string, double> Rates
        {
            get;
            set;
        }
    }
}

