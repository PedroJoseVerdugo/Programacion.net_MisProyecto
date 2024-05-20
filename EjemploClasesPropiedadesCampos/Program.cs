
using EjemploClasesPropiedadesCampos;


    

coche Ferrari = new coche();

coche SeatPanda = new coche();
coche Renault = new coche();
coche bmw = new coche();
coche FordFiesta = new coche();
FordFiesta.NumeroPuertas = 5;
Ferrari.NumeroPuertas = 2;
SeatPanda.NumeroPuertas = 4;
bmw.NumeroPuertas = 4;
Renault.NumeroPuertas = 5;

FordFiesta.color = "rojo";
Ferrari.color = "blanco";
SeatPanda.color = "amarillo";
bmw.color = "azul";
Renault.color = "naranja";

FordFiesta.Matricula = "12";
Ferrari.Matricula = "23";
SeatPanda.Matricula = "34";
bmw.Matricula = "45";
Renault.Matricula = "56";



   
 


Persona juan = new Persona();
juan.Nombre = "Juan";
juan.Apellidos = "Lopez";
juan.ColorPelo = "Rubio intenso numero 7";
juan.Estatura = 1.80;
juan.Dni = "12345678G";
juan.Telefono = 916019999;

Persona Mario = new Persona();
Mario.Nombre = "Mario";
Mario.Apellidos = "Martinez";
Mario.ColorPelo = "Marron";
Mario.Estatura = 1.65;

Persona Maria = new Persona();
Maria.Nombre = "Maria d ela O";

Animal Tigre = new Animal();
Tigre.Nombre = "Huevon";
Tigre.Identificacion = 12345;

Animal Perro = new Animal();
Perro.Nombre = "Lucas";
Perro.Identificacion = 234567;

static void Main(string[] args)
{ 
Persona NumeroSeguridadSocial = new Persona();

    NumeroSeguridadSocial.EstablecerNss("122344");

    string Nss = NumeroSeguridadSocial.RecuperarNss();
    Console.WriteLine("Numero de la seguridad social: " + Nss);



 }




