using System;
using System.Collections.Generic;

namespace DeskArt_Back.Models;

public partial class Merma
{
    public int IdMerma { get; set; }

    public int? Cantidad { get; set; }

    public string? Descripción { get; set; }

    public int? MateriaPIdMateriaP { get; set; }

    public int? UsuarioTiendaIdUsuarioTienda { get; set; }

    public virtual MateriaP? MateriaPIdMateriaPNavigation { get; set; }

    public virtual UsuarioTiendum? UsuarioTiendaIdUsuarioTiendaNavigation { get; set; }
}
