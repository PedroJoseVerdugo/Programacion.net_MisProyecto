namespace WebApplicationTrabajoFinalMvc.Models.Servicios;

public class SaludoEnAleman : ISaludo
{
    public string Mensaje { get; set; }
    public string Saludo()
    {
        return "Hallo Welt";
    }
}
