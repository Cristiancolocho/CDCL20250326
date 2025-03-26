﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDCL20250326.AppWebMVC.Models;

public partial class Warehouse
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre de la bodega es obligatorio.")]
    [Display(Name = "Bodega")]
    public string WarehouseName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
