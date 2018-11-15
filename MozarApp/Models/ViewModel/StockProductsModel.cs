using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Models.ViewModel
{

    public class SaleOff
    {
        public string ProductName { get; set; }
        public ProductSaleImage Images { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
    }

    public class NewProduct
    {
        public string ProductName { get; set; }
        public ProductSaleImage Images { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
    }

    public class ProductSaleImage
    {
        public string ProductImage { get; set; }
        public string HoverImage { get; set; }
    }

    public class StockProductsModel
    {
        public IEnumerable<SaleOff> SaleOffs { get; set; }
        public IEnumerable<NewProduct> NewProducts { get; set; }
    }


}
