using Shop.Application.Common;
using Shop.Data.EF;
using Shop.ViewModels.Catalog.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Shop.Application.Catalog.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly ShopDbContext _context;
      
        public CategoryService(ShopDbContext context)
        {
            _context = context;
         
        }

        public async Task<List<CategoryVm>> GetAll(string languageId)
        {
            var query = from c in _context.Categories
                        join ct in _context.CategoryTranslations on c.Id equals ct.CategoryId
                        where ct.LanguageId == languageId
                        select new { c, ct };

            return await query.Select(x => new CategoryVm()
            {
                Id = x.c.Id,
                Name = x.ct.Name
            }).ToListAsync();
        }
    }
}
