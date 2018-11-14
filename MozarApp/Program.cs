using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MozarApp.Models;

namespace MozarApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IWebHost webHost = CreateWebHostBuilder(args).Build();

            using (IServiceScope serviceScope = webHost.Services.CreateScope())
            {
                using (MozarDbContext mozarDbContext = serviceScope.ServiceProvider.GetRequiredService<MozarDbContext>())
                {
                    if (mozarDbContext.Categories.Count() == 0)
                    {

                    }

                    #region add product and images + stock info
                    if (mozarDbContext.Products.Count() == 0)
                    {

                        Product product = new Product
                        {
                            Name = "Product"
                        };
                        Product product_2 = new Product
                        {
                            Name = "Product_2"
                        };
                        Product product_3 = new Product
                        {
                            Name = "Product_3"
                        };
                        Product product_4 = new Product
                        {
                            Name = "Product_4"
                        };

                        mozarDbContext.Products.AddRange(product, product_2, product_3, product_4);
                        mozarDbContext.SaveChanges();

                        ProductImage productImage = new ProductImage
                        {
                            Path = "2.jpg",
                            ProductId = product.Id
                        };
                        ProductImage productImage__2 = new ProductImage
                        {
                            Path = "3.jpg",
                            ProductId = product.Id
                        };

                        ProductImage productImage2__ = new ProductImage
                        {
                            Path = "4.jpg",
                            ProductId = product_2.Id
                        };
                        ProductImage productImage2__2 = new ProductImage
                        {
                            Path = "5.jpg",
                            ProductId = product_2.Id
                        };

                        ProductImage productImage3__ = new ProductImage
                        {
                            Path = "6.jpg",
                            ProductId = product_3.Id
                        };
                        ProductImage productImage3__2 = new ProductImage
                        {
                            Path = "7.jpg",
                            ProductId = product_3.Id
                        };

                        ProductImage productImage4__ = new ProductImage
                        {
                            Path = "8.jpg",
                            ProductId = product_4.Id
                        };
                        ProductImage productImage4__2 = new ProductImage
                        {
                            Path = "9.jpg",
                            ProductId = product_4.Id
                        };

                        mozarDbContext.Images.AddRange(productImage, productImage__2, productImage2__, productImage2__2, productImage3__, productImage3__2, productImage4__, productImage4__2);
                        mozarDbContext.SaveChanges();


                        Stock stock = new Stock();
                        stock.ProductId = product.Id;
                        stock.Price = 657;
                        stock.DiscountPercentage = 4;
                        stock.Count = 67;
                        stock.Description = "This is product 1";

                        Stock stock2 = new Stock();
                        stock2.ProductId = product_2.Id;
                        stock2.Price = 1200;
                        stock2.DiscountPercentage = 14;
                        stock2.Count = 34;
                        stock2.Description = "This is product 2";

                        Stock stock3 = new Stock();
                        stock3.ProductId = product_3.Id;
                        stock3.Price = 340;
                        stock3.DiscountPercentage = 2;
                        stock3.Count = 4;
                        stock3.Description = "This is product 3";

                        Stock stock4 = new Stock();
                        stock4.ProductId = product_4.Id;
                        stock4.Price = 2300;
                        stock4.DiscountPercentage = 30;
                        stock4.Count = 24;
                        stock4.Description = "This is product 4";

                        mozarDbContext.Stock.AddRange(stock, stock2, stock3, stock4);
                        mozarDbContext.SaveChanges();
                    }
                    #endregion

                   

                }

                webHost.Run();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
