using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.Models
{
    public class MozarDbContext:IdentityDbContext<AppUser>
    {
        public MozarDbContext(DbContextOptions<MozarDbContext> dbContextOptions):base(dbContextOptions)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Stock> Stock { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<NestedCategory> NestedCategories { get; set; }
        public DbSet<ProductComment> Comments { get; set; }
        public DbSet<ProductImage> Images { get; set; }
    }
}
