using WebApplicationTrabajoFinalMvc.ViewModels;


namespace WebApplicationTrabajoFinalMvc.ViewModels
{
    public class ConversorIndexViewModel
    {
        public string Id { get; set; }
        public string MonedaOrigen { get; set; }
        public string MonedaDestino { get; set; }
        public string Importe { get; set; }
        public string Resultado { get; set; }
        public string Fecha { get; set; }
        public string Factor { get; set; }
        public string Usuario { get; set; }
        public List<string> ListaMonedas { get; set; }
    }
}
