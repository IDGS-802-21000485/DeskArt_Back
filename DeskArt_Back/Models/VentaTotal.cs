using System;
using System.Collections.Generic;

namespace DeskArt_Back.Models;

public partial class VentaTotal
{
    public int IdVentaTotal { get; set; }

    public string? Descripcion { get; set; }

    public double? Total { get; set; }

    public int? VentaProdIdVentaProd { get; set; }

    public virtual ICollection<Producción> Produccións { get; set; } = new List<Producción>();

    public virtual VentaProd? VentaProdIdVentaProdNavigation { get; set; }
}
