using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Models
{
    public class MenuModel
    {
        public Category Category { get; set; }
        public IEnumerable<SubCategoryModel> SubCategories { get; set; }
    }

    public class SubCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<NestedCategoryModel> NestedCategories { get; set; }   
    }
    public class NestedCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
