using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Web;

namespace Crudcodefirst.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Nombre del producto requerido")]
        [DisplayName("Nombre del producto")]

        public string ProductName { get; set; }


        [Required(ErrorMessage = "Precio requerido")]
        [DisplayName("Precio")]

        public decimal Price { get; set; }

        [Required(ErrorMessage = "Cantidad requerida")]
        [DisplayName("Cantidad")]
        public int Qty { get; set; }

        [DisplayName("Observaciones")]
        public string Remarks { get; set; }

    }

    public class EFCodeFirstEntieis: DbContext
    {
        public DbSet<Product> products { get; set; }
    }

}