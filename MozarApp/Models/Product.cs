using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Models
{
    public class Product
    {

        public Product()
        {
            Comments = new HashSet<ProductComment>();
            Images = new HashSet<ProductImage>();
        }
      
        public int Id { get; set; }

        public ICollection<ProductImage> Images { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<ProductComment> Comments { get; set; }

    }
}
