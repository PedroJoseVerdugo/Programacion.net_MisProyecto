using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
   public class Empleado
    {
        public string Nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Turno { get; set; }
        public double Salario { get; set; }
        public Empleado()//constructor se define porq el nombre dela clase
                         //y no devuleve nada
                         //constructor por defecto(sin parametros)
        {
        }
        public Empleado(string nombre, DateTime fechaalta, string turno, double salario)
        {
            this.Nombre = nombre;
            this.FechaAlta = fechaalta;
            this.Turno = turno;
            this.Salario = salario;
        }

    }
}
