using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Models
{
    [Table(name: "Comments", Schema = "dbo")]
    public class ProductComment
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        [Required]
        public int ProductId { get; set; }
        public AppUser AppUser { get; set; }
        [Required]
        public int AppUserId { get; set; }
        [Required]
        [MinLength(5)]
        public string Text { get; set; }

    }
}
