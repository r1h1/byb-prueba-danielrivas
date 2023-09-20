using System;
using System.Collections.Generic;

namespace pruebaCrudProductosMvc.Models;

public partial class Producto
{
    public int Id { get; set; }

    public int? CodigoProducto { get; set; }

    public string? NombreProducto { get; set; }

    public decimal? PrecioProducto { get; set; }

    public DateTime? FechaProducto { get; set; }
}
