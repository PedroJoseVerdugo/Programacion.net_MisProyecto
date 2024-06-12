﻿namespace WebApplicationTrabajoFinalMvc.Models;

public class Usuario
{


    public int Id { get; set; }
    public string Nombre { get; set; }  
    public string Apellidos { get; set; }
    public string Email { get; set;}
    public string Contraseña { get; set; }
    public DateTime FechaNacimiento { get; set; }
    public string NombreUsuario { get; set; }
    public string Pais { get; internal set; }
}
