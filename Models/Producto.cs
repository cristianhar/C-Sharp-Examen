﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EfPowerTools.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string NombreProducto { get; set; }

    public int? Cantidad { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public string ImagenProducto { get; set; }

    public DateTime? FechaVencimiento { get; set; }

    public string Origen { get; set; }

    public string CodigoInvima { get; set; }

    public decimal? Precio { get; set; }

    public string TipoProducto { get; set; }

    public string NombreProveedor { get; set; }
}