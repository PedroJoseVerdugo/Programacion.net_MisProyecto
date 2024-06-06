
using System;


namespace WebApplication3_06_2024.Models
{



    public class Empleado
    {
        public string Nombre { get; set; }
        public DateTime FechaAlta { get; set; }
        public string Turno { get; set; }
        public int Salario { get; set; }
        public int TotalVacaciones { get; set; }
        public int VacacionesDisfrutadas { get; set; }
        public int VacacionesRestantes { get; private set; }

        // Constructor principal
        public Empleado(string nombre, DateTime fechaAlta, string turno, int salario, int totalVacaciones, int vacacionesDisfrutadas)
        {
            Nombre = nombre;
            FechaAlta = fechaAlta;
            Turno = turno;
            Salario = salario;
            TotalVacaciones = totalVacaciones;
            VacacionesDisfrutadas = vacacionesDisfrutadas;
            CalcularVacacionesRestantes();
        }

        // Método para calcular las vacaciones restantes
        public void CalcularVacacionesRestantes()
        {
            VacacionesRestantes = TotalVacaciones - VacacionesDisfrutadas;
        }

        // Sobreescritura del método ToString para fácil visualización
        public override string ToString()
        {
            return $"Empleado: {Nombre}, Fecha Alta: {FechaAlta.ToShortDateString()}, Turno: {Turno}, Salario: {Salario}, Total Vacaciones: {TotalVacaciones}, Vacaciones Disfrutadas: {VacacionesDisfrutadas}, Vacaciones Restantes: {VacacionesRestantes}";
        }
    }
}

