using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.ViewModels.Catalog.Categories;
using Shop.ViewModels.Catalog.Products;
using Shop.ViewModels.Common;

namespace Shop.WebApp.Models
{
    public class ProductCategoryViewModel
    {
        public CategoryVm Category { get; set; }

        public PageResult<ProductVm> Products { get; set; }
    }
}
