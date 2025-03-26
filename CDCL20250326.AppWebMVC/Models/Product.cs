using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CDCL20250326.AppWebMVC.Models;

public partial class Product
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
    [Display(Name = "Producto")]
    public string ProductName { get; set; } = null!;
    [Required(ErrorMessage = "Debe de ingresar una descripción.")]
    [Display(Name = "Descripción")]
    public string? Description { get; set; }
    [Required(ErrorMessage = "Precio es obligatorio.")]
    [Display(Name = "Precio")]
    public decimal Price { get; set; }

    public int? WarehouseId { get; set; }

    public int? BrandId { get; set; }

    public virtual Brand? Brand { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
