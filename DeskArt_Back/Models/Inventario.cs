using System;
using System.Collections.Generic;

namespace DeskArt_Back.Models;

public partial class Inventario
{
    public int IdInventario { get; set; }

    public string? Cantidad { get; set; }

    public int? MateriaPIdMateriaP { get; set; }

    public virtual MateriaP? MateriaPIdMateriaPNavigation { get; set; }
}
