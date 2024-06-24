using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using FinalTrabajo.Services;


namespace FinalTrabajo.Models
{
    public class ConversorMonedaConversionViewModel
    {
        public ConversorMonedaConversionViewModel()
        {
            SourceCurrency = string.Empty;
            TargetCurrency = string.Empty;
            ValidCurrencyCodes = new List<string>();
        }

        [BindNever]
        public List<string> ValidCurrencyCodes { get; set; }


        [Required(ErrorMessage = "El importe es requerido")]
        [RegularExpression(@"^\d+(\.\d{2,})?$", ErrorMessage = "El importe debe tener al menos dos decimales.")]
        public decimal Amount { get; set; }
        //[Required(ErrorMessage = "El importe es requerido")]
        //[RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "El importe debe ser un número decimal válido con hasta 2 decimales.")]
        //public decimal Amount { get; set; }



        //[Required(ErrorMessage = "El importe es requerido")]
        //[Range(0.01, double.MaxValue, ErrorMessage = "El importe debe ser mayor que 0")]

        //[Range(typeof(decimal), "0.01", "79228162514264337593543950335", ErrorMessage = "El importe debe ser mayor que 0")]
        //public decimal Amount { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "La divisa de origen debe ser de 3 caracteres")]
        public string SourceCurrency { get; set; }

        [Required]
        [StringLength(3, ErrorMessage = "La divisa de destino debe ser de 3 caracteres")]
        public string TargetCurrency { get; set; }

        public decimal Result { get; set; }
    }
}
