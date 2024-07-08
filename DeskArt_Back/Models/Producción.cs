using System;
using System.Collections.Generic;

namespace DeskArt_Back.Models;

public partial class Producción
{
    public int IdProducción { get; set; }

    public int? VentaTotalIdVentaTotal { get; set; }

    public int? EstadoProducIdEstadoProduc { get; set; }

    public virtual EstadoProduc? EstadoProducIdEstadoProducNavigation { get; set; }

    public virtual VentaTotal? VentaTotalIdVentaTotalNavigation { get; set; }
}
