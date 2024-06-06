
namespace ProyectowebMVC.Servicios;

public class ServicioConversionMoneda
{
    //crear un campo para guardar el httpClient
    private readonly HttpClient _httpClient;


    //Guardar el ApiKey
    private readonly string _apiKey ="f8c975868ee6a437db59716d";

        
    public ServicioConversionMoneda(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }


    public async Task<string> ObtenerMonedas()
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

        }

        return contenidoJson;

    }

}
