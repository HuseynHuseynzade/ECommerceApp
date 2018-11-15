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
                        Product product_5 = new Product
                        {
                            Name = "Product_5"
                        };
                        Product product_6 = new Product
                        {
                            Name = "Product_6"
                        };
                        Product product_7 = new Product
                        {
                            Name = "Product_7"
                        };
                        Product product_8 = new Product
                        {
                            Name = "Product_8"
                        };
                        Product product_9 = new Product
                        {
                            Name = "Product_9"
                        };
                        Product product_10 = new Product
                        {
                            Name = "Product_10"
                        };

                        mozarDbContext.Products.AddRange(product, product_2, product_3, product_4,product_5,product_6,product_7,product_8,product_9,product_10);
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

                        ProductImage productImage5__ = new ProductImage
                        {
                            Path = "10.jpg",
                            ProductId = product_5.Id
                        };
                        ProductImage productImage5__2 = new ProductImage
                        {
                            Path = "11.jpg",
                            ProductId = product_5.Id
                        };

                        ProductImage productImage6__ = new ProductImage
                        {
                            Path = "12.jpg",
                            ProductId = product_6.Id
                        };
                        ProductImage productImage6__2 = new ProductImage
                        {
                            Path = "13.jpg",
                            ProductId = product_6.Id
                        };

                        ProductImage productImage7__ = new ProductImage
                        {
                            Path = "14.jpg",
                            ProductId = product_7.Id
                        };
                        ProductImage productImage7__2 = new ProductImage
                        {
                            Path = "15.jpg",
                            ProductId = product_7.Id
                        };

                        ProductImage productImage8__ = new ProductImage
                        {
                            Path = "17.jpg",
                            ProductId = product_8.Id
                        };
                        ProductImage productImage8__2 = new ProductImage
                        {
                            Path = "18.jpg",
                            ProductId = product_8.Id
                        };

                        ProductImage productImage9__ = new ProductImage
                        {
                            Path = "19.jpg",
                            ProductId = product_9.Id
                        };
                        ProductImage productImage9__2 = new ProductImage
                        {
                            Path = "20.jpg",
                            ProductId = product_9.Id
                        };

                        ProductImage productImage10__ = new ProductImage
                        {
                            Path = "16.jpg",
                            ProductId = product_10.Id
                        };
                        ProductImage productImage10__2 = new ProductImage
                        {
                            Path = "quick-view.jpg",
                            ProductId = product_10.Id
                        };

                        mozarDbContext.Images.AddRange(productImage, productImage__2, productImage2__, productImage2__2, productImage3__, productImage3__2, productImage4__, productImage4__2,productImage5__,productImage5__2,productImage6__,productImage6__2,productImage7__,productImage7__2,productImage8__,productImage8__2,productImage9__,productImage9__2,productImage10__,productImage10__2);
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

                        Stock stock5 = new Stock();
                        stock5.ProductId = product_5.Id;
                        stock5.Price = 356;
                        stock5.DiscountPercentage = 0;
                        stock5.Count = 32;
                        stock5.Description = "This is product 5";

                        Stock stock6 = new Stock();
                        stock6.ProductId = product_6.Id;
                        stock6.Price = 1100;
                        stock6.DiscountPercentage = 0;
                        stock6.Count = 16;
                        stock6.Description = "This is product 6";

                        Stock stock7 = new Stock();
                        stock7.ProductId = product_7.Id;
                        stock7.Price = 2100;
                        stock7.DiscountPercentage = 15;
                        stock7.Count = 21;
                        stock7.Description = "This is product 7";

                        Stock stock8 = new Stock();
                        stock8.ProductId = product_8.Id;
                        stock8.Price = 250;
                        stock8.DiscountPercentage = 0;
                        stock8.Count = 25;
                        stock8.Description = "This is product 8";

                        Stock stock9 = new Stock();
                        stock9.ProductId = product_9.Id;
                        stock9.Price = 3000;
                        stock9.DiscountPercentage = 20;
                        stock9.Count = 10;
                        stock9.Description = "This is product 9";

                        Stock stock10 = new Stock();
                        stock10.ProductId = product_10.Id;
                        stock10.Price = 200;
                        stock10.DiscountPercentage = 0;
                        stock10.Count = 50;
                        stock10.Description = "This is product 10";


                        mozarDbContext.Stock.AddRange(stock, stock2, stock3, stock4,stock5,stock6,stock7,stock8,stock9,stock10);
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
