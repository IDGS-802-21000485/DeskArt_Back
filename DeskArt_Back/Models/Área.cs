using System;
using System.Collections.Generic;

namespace DeskArt_Back.Models;

public partial class Área
{
    public int IdÁrea { get; set; }

    public string? Tipo { get; set; }

    public virtual ICollection<UsuarioTiendum> UsuarioTienda { get; set; } = new List<UsuarioTiendum>();
}
