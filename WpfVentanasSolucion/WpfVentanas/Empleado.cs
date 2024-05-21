using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfVentanas
{
    public class Empleado
    {
         
        // Propiedades del empleado
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroSeguridadSocial { get; set; }
        public string Posicion { get; set; }
        public double Salario { get; set; }

        
        // Constructor con parámetros
        public Empleado(string nombre, string apellido, string numeroSeguridadSocial, string posicion, double salario)
        {
            Nombre = nombre;
            Apellido = apellido;
            NumeroSeguridadSocial = numeroSeguridadSocial;
            Posicion = posicion;
            Salario = salario;
        }

        // Método para mostrar la información del empleado
        public string MostrarInformacion()
        {
            return $"Nombre: {Nombre} {Apellido}\n" +
                   $"NSS: {NumeroSeguridadSocial}\n" +
                   $"Posición: {Posicion}\n" +
                   $"Salario: {Salario:C}";
        }
    }

}

