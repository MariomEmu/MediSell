﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BLL.DTOs
{
    public class ProductsOrderDto
    {
        [Key] public int Id { get; set; }

        [Required] public int Quantity { get; set; }

        // Foreign Key
        [ForeignKey("Product")] public int ProductId { get; set; }

        [ForeignKey("Order")] public int OrderId { get; set; }
    }
}