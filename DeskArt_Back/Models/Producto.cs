using System;
using System.Collections.Generic;

namespace DeskArt_Back.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Alto { get; set; }

    public string? Largo { get; set; }

    public string? Ancho { get; set; }

    public string? Precio { get; set; }

    public int? ÁreaIdÁrea { get; set; }

    public virtual ICollection<Recetum> Receta { get; set; } = new List<Recetum>();

    public virtual ICollection<VentaProd> VentaProds { get; set; } = new List<VentaProd>();

    public virtual Área? ÁreaIdÁreaNavigation { get; set; }
}
