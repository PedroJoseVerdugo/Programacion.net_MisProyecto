namespace WebApplicationTrabajoFinalMvc.ViewModels
{
    public class ConversorIndexViewModel
    {
        public string monedaOrigen { get; set; }
        public string monedaDestino { get; set; }
        public string importe { get; set; }
        public string resultado { get; set; }
        public List<string> ListaMonedas { get; set; }
    }
}
