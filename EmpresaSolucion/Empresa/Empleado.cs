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
        public int TVacaciones { get; set; }
        public int DiasVacaciones { get; set; } 
        public Empleado()//constructor se define porq el nombre dela clase
                         //y no devuleve nada
                         //constructor por defecto(sin parametros)
        {
            this.DiasVacaciones = 30;
        }
        public Empleado(string nombre, DateTime fechaalta, string turno, double salario, int Tvacaciones)
        {
            this.Nombre = nombre;
            this.FechaAlta = fechaalta;
            this.Turno = turno;
            this.Salario = salario;
            this.TVacaciones = Tvacaciones;
            this.DiasVacaciones = 30;

        }
        public void DescontarDiasVacaciones(int diasUtilizados)
        {
            if (diasUtilizados <= DiasVacaciones)
            {
                DiasVacaciones -= diasUtilizados;
            }
            else
            {
                Console.WriteLine($"{Nombre} no tiene suficientes días de vacaciones.");
            }
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Fecha de Alta: {FechaAlta.ToShortDateString()}");
            Console.WriteLine($"Turno: {Turno}");
            Console.WriteLine($"Salario: {Salario}");
            Console.WriteLine($"Total Vacaciones: {TVacaciones}");
            Console.WriteLine($"Días de Vacaciones Restantes: {DiasVacaciones}");
            Console.WriteLine(new string('-', 30)); // Línea separadora
        }

    }
}
/*
al incio del año todos tienen 30 dias de vacaciones y hay que descontar los dias que se pide cada empleado
hacer metodo para descontar dias de vacaciones ya disfrutados
cuantos dias tiene cada empleado? (foreach)

Carlos vacaciones inicio 30 dias
a pedido en eenero 4 dias
dias restantes  26 dias

Felipe vacaciones inicio 30 dias
pedido en 10 dias
total restantes 20*/
