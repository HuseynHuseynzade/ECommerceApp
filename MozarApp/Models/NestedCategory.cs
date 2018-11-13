using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Models
{
    public class NestedCategory:MenuEntity
    {
        public SubCategory SubCategory { get; set; }
        public int SubCategoryId { get; set; }
    }
}
