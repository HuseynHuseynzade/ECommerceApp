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
                        //add
                    }
                    if (mozarDbContext.Products.Count() == 0)
                    {
                        Product product = new Product
                        {
                            Name = "1"
                        };
                        Product product2 = new Product
                        {
                            Name = "2"
                        };
                        Product product3 = new Product
                        {
                            Name = "3"
                        };
                        Product product4 = new Product
                        {
                            Name = "4"
                        };
                        Product product5 = new Product
                        {
                            Name = "5"

                        };
                        Product product6 = new Product
                        {
                            Name = "6"
                        };
                        Product product7 = new Product
                        {
                            Name = "7"
                        };
                        Product product8 = new Product
                        {
                            Name = "8"
                        };
                        Product product9 = new Product
                        {
                            Name = "9"
                        };


                        mozarDbContext.Products.AddRange(product, product2);
                        mozarDbContext.SaveChanges();

                        ProductImage productImage = new ProductImage
                        {
                            Path = "1.jpg",
                            ProductId = product.Id
                        };
                        ProductImage productImage2 = new ProductImage
                        {
                            Path = "2.jpg",
                            ProductId = product.Id
                        };
                        ProductImage productImage3 = new ProductImage
                        {
                            Path = "6.jpg",
                            ProductId = product.Id
                        };
                        ProductImage productImage4 = new ProductImage
                        {
                            Path = "4.jpg",
                            ProductId = product.Id
                        };
                        ProductImage productImage5 = new ProductImage
                        {
                            Path = "5.jpg",
                            ProductId = product.Id
                        };
                        ProductImage productImage6 = new ProductImage
                        {
                            Path = "6.jpg",
                            ProductId = product.Id
                        };
                        ProductImage productImage7 = new ProductImage
                        {
                            Path = "7.jpg",
                            ProductId = product.Id
                        };
                        ProductImage productImage8 = new ProductImage
                        {
                            Path = "8.jpg",
                            ProductId = product.Id
                        };
                        ProductImage productImage9 = new ProductImage
                        {
                            Path = "9.jpg",
                            ProductId = product.Id
                        };


                        mozarDbContext.Images.Add(productImage);
                        mozarDbContext.SaveChanges();
                    }

                }

                webHost.Run();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
