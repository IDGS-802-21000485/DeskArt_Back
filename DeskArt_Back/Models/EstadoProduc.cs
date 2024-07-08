using System;
using System.Collections.Generic;

namespace DeskArt_Back.Models;

public partial class EstadoProduc
{
    public int IdEstadoProduc { get; set; }

    public string? Descripción { get; set; }

    public virtual ICollection<Producción> Produccións { get; set; } = new List<Producción>();
}
