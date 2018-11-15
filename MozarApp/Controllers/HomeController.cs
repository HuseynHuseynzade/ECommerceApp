using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MozarApp.Infrastructure;
using MozarApp.Models;
using MozarApp.Models.ViewModel;

namespace MozarApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly MozarDbContext _mozarDbContext;
        private readonly IDiscountCalculator _discountCalculator;

        public HomeController(MozarDbContext mozarDbContext,IDiscountCalculator discountCalculator)
        {
            _mozarDbContext = mozarDbContext;
            _discountCalculator = discountCalculator;
        }
        public async Task<IActionResult>  Index()
        {
            StockProductsModel stockProductsModel = new StockProductsModel();
            



            stockProductsModel.SaleOffs= await _mozarDbContext.Stock.OrderByDescending(x => x.DiscountPercentage)
                                      .Include(x => x.Product)
                                             .Include(x => x.Product.Images)
                                             .Take(6)
                                                .Select(x => new SaleOff()
                                                {
                                                    ProductName = x.Product.Name,
                                                    OldPrice = x.Price,
                                                    NewPrice = _discountCalculator.GetDiscount(x.Price,x.DiscountPercentage),
                                                    Images = new ProductSaleImage()
                                                    {
                                                        HoverImage = x.Product.Images.Skip(1).FirstOrDefault().Path,
                                                        ProductImage=x.Product.Images.FirstOrDefault().Path
                                                    }
                                                }).ToListAsync();

            stockProductsModel.NewProducts = await _mozarDbContext.Stock.OrderByDescending(x => x.DiscountPercentage)
                                      .Include(x => x.Product)
                                             .Include(x => x.Product.Images)
                                             .Take(8)
                                                .Select(x => new NewProduct()
                                                {
                                                    
                                                    ProductName = x.Product.Name,
                                                    OldPrice = x.Price,
                                                    
                                                    NewPrice = _discountCalculator.GetDiscount(x.Price, x.DiscountPercentage),
                                                    Images = new ProductSaleImage()
                                                    {
                                                        HoverImage = x.Product.Images.Skip(1).FirstOrDefault().Path,
                                                        ProductImage = x.Product.Images.FirstOrDefault().Path
                                                    }
                                                }).ToListAsync();

            return View(stockProductsModel);
        }
    }
}