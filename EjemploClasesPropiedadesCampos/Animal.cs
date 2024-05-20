using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClasesPropiedadesCampos
{
    public class Animal
    {
        public string ColorPelaje { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public  int Identificacion { get; set; }
        public int NumeroPatas { get; set; }
        public string Genero { get; set; }
        private bool Protegido;
}
}
