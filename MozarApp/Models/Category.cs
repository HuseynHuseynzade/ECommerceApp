using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Models
{
    public class Category:MenuEntity
    {
        public Category()
        {
            SubCategories = new HashSet<SubCategory>();
        }
        public ICollection<SubCategory> SubCategories { get; set; }

    }
}
