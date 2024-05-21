namespace Empresa
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(new string('-', 30)); // Línea separadora
            Console.WriteLine(new string('-', 30)); // Línea separadora
            Console.WriteLine(new string('-', 30)); // Línea separadora

            Console.WriteLine("HOLA BIENVENIDOS ALA INFORMACION DE LOS EMPLEADOS!");

            Console.WriteLine(new string('-', 30)); // Línea separadora
            Console.WriteLine(new string('-', 30)); // Línea separadora
            Console.WriteLine(new string('-', 30)); // Línea separadora

            //Crear Tony
            var emp1 = new Empleado();//todas las clases vienene de object
                                      
            emp1.Nombre = "Tony";
            emp1.FechaAlta = new DateTime(2021, 1, 1);
            emp1.Turno = "Turno";
            emp1.Salario = 20000;

            //emp1.ToString(); de aqui salen todas las clases

            //Crear pepe
            var emp2 = new Empleado()
            {
                Nombre = "Pepe",
                FechaAlta = new DateTime(2023 / 2 / 1),
                Turno = "Mañana",
                Salario = 21000,

            };
            //crera clase maria mediante el constructor
            var emp3 = new Empleado("Maria",
                                    new DateTime(2023, 7, 1),
                                    ("Mañana"),
                                    22000
                                    ) ;

            /*--------EJERCICIO------*/

            //crear empleado Carlos 21 / 5 / 2024  Nocturo   26.000 (como Tony)
            // crear empleado Yuby  25 / 5 / 2024  Mañana    26.000 (como pepe)
            //crear empleado Juan   10 / 5 / 2024  Tarde    26.000 (como MAria)

            var emp4 = new Empleado();

            emp4.Nombre = "Carlos";
            emp4.FechaAlta = new DateTime(2024, 5, 21);
            emp4.Turno = "Nocturno";
            emp4.Salario = 26000;

            var emp5 = new Empleado()
            {
                Nombre = "Yuby",
                FechaAlta = new DateTime(2024 / 5 / 25),
                Turno = "Mañana",
                Salario = 26000,

            };
            var emp6 = new Empleado("Juan",
                                   new DateTime(2024, 5, 10),
                                   ("Tarde"),
                                   26000);


            /*  ----MOSTRAR IOMFORMACION-----  */
            //emp1                  
            Console.WriteLine($"Nombre: {emp1.Nombre}");
            Console.WriteLine($"Fecha de Alta: {emp1.FechaAlta}");
            Console.WriteLine($"Turno: {emp1.Turno}");
            Console.WriteLine($"Salario: {emp1.Salario}");


            Console.WriteLine(new string('-', 30)); // Línea separadora

            //emp2
            Console.WriteLine($"Nombre: {emp2.Nombre}");
            Console.WriteLine($"Fecha de Alta: {emp2.FechaAlta}");
            Console.WriteLine($"Turno: {emp2.Turno}");
            Console.WriteLine($"Salario: {emp2.Salario}");

            Console.WriteLine(new string('-', 30)); // Línea separadora

            //emp3
            Console.WriteLine($"Nombre: {emp3.Nombre}");
            Console.WriteLine($"Fecha de Alta: {emp3.FechaAlta}");
            Console.WriteLine($"Turno: {emp3.Turno}");
            Console.WriteLine($"Salario: {emp3.Salario}");

            Console.WriteLine(new string('-', 30)); // Línea separadora

            //emp4
            Console.WriteLine($"Nombre: {emp4.Nombre}");
            Console.WriteLine($"Fecha de Alta: {emp4.FechaAlta}");
            Console.WriteLine($"Turno: {emp4.Turno}");
            Console.WriteLine($"Salario: {emp4.Salario}");

            Console.WriteLine(new string('-', 30)); // Línea separadora

            //emp5
            Console.WriteLine($"Nombre: {emp5.Nombre}");
            Console.WriteLine($"Fecha de Alta: {emp5.FechaAlta}");
            Console.WriteLine($"Turno: {emp5.Turno}");
            Console.WriteLine($"Salario: {emp5.Salario}");

            Console.WriteLine(new string('-', 30)); // Línea separadora

            //emp6
            Console.WriteLine($"Nombre: {emp6.Nombre}");
            Console.WriteLine($"Fecha de Alta: {emp6.FechaAlta}");
            Console.WriteLine($"Turno: {emp6.Turno}");
            Console.WriteLine($"Salario: {emp6.Salario}");
            /*
            Console.WriteLine($"Nombre: {emp7.Nombre}");
            Console.WriteLine($"Fecha de Alta: {emp7.FechaAlta}");
            Console.WriteLine($"Turno: {emp7.Turno}");
            Console.WriteLine($"Salario: {emp7.Salario}");
            */


            Console.WriteLine(new string('-', 30)); // Línea separadora

        }


    }
}
