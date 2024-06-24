namespace FinalTrabajo.Models
{


    public class ConversorMonedaQuery
    {
        public string MonedaOrigen { get; set; }
        public string MonedaDestino { get; set; }
        public decimal Importe { get; set; }
        public decimal Resultado { get; set; }
        public decimal Factor { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
    }
}
