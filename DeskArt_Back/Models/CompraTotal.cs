using System;
using System.Collections.Generic;

namespace DeskArt_Back.Models;

public partial class CompraTotal
{
    public int IdCompra { get; set; }

    public string? Descripción { get; set; }

    public double? Total { get; set; }

    public int? CompraProdIdCompraProd { get; set; }

    public virtual CompraProd? CompraProdIdCompraProdNavigation { get; set; }
}
