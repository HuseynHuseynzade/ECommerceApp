using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Models
{
    public class SubCategory:MenuEntity
    {
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public ICollection<NestedCategory> NestedCategories { get; set; }
        public SubCategory()
        {
            NestedCategories = new HashSet<NestedCategory>();
        }
    }
}
