namespace WebApplicationTrabajoFinalMvc.Models.Servicios;

public class SaludoEnFrances : ISaludo
{
    public string Mensaje { get; set; }
    public string Saludo()
    {
        return "Bonjour le monde";
    }
}
