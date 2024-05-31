var builder = WebApplication.CreateBuilder(args);
//1-Agregar servicios

//Agregar MVC -> Modelo-Vista-Controlador

//               Necesario para las Apis

builder.Services.AddControllers();

//Agregar Documentacion Automatica Api
builder.Services.AddSwaggerGen();


//=================
var app = builder.Build();
//================
//2-Configurar peticiones: softwear intermedios Middleware






//app.UseWelcomePage();   
/*
app.MapGet("/", () => "Hola mundo!");//mapea una direcion raiz muestra hola mundo
app.MapGet("/acercade",() => "acerca de nuestra empresa");*/
app.UseSwagger();
app.UseSwaggerUI();


app.MapControllers();

app.Run();
