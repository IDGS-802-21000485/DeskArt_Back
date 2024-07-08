using System;
using System.Collections.Generic;

namespace DeskArt_Back.Models;

public partial class LoginMobil
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Contrasena { get; set; } = null!;

    public string Sexo { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Cp { get; set; } = null!;
}
