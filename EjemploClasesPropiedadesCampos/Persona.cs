using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploClasesPropiedadesCampos
{
    public class Persona
    {


        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string ColorPelo { get; set; }

        public double Estatura { get; set; }

        public string Dni { get; set; }

        public int Telefono { get; set; }

        private string NumeroSeguridadSocial;

        public void EstablecerNss(string Nss)
        {
            NumeroSeguridadSocial = Nss;

        }
        public string RecuperarNss()
        {
            return NumeroSeguridadSocial;
        }



    }
}
