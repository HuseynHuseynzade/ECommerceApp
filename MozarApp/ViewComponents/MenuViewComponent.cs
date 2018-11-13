using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore;
using MozarApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MozarApp.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private readonly MozarDbContext _mozarDbContext;

        //asililigin yeridilmesi = Dependency Injection = vnedreniya zavisimost
        public MenuViewComponent(MozarDbContext mozarDbContext)
        {
            _mozarDbContext = mozarDbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var data = await _mozarDbContext.Categories.Include(x => x.SubCategories)
                                                      .Select(x => new MenuModel()
                                                      {
                                                          Category = x,
                                                          SubCategories = x.SubCategories.Select(y => new SubCategoryModel()
                                                          {
                                                              Id = y.Id,
                                                              Name = y.Name,
                                                              NestedCategories = y.NestedCategories
                                                                   .Select(z => new NestedCategoryModel()
                                                                   { Id = z.Id, Name = z.Name })
                                                          })
                                                      }).ToListAsync();

            return View(data);
        }
    }
}
