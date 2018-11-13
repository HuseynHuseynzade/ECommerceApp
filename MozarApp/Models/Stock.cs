using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Models
{
    [Table(name:"Stock",Schema ="dbo")]
    public class Stock
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(3,1)")]
        public decimal DiscountPercentage { get; set; }

        [Required]
        public string Description { get; set; }

        public int Count { get; set; }
    }
}
