using Shop.ViewModels.Catalog.Products;
using Shop.ViewModels.Utilities.Slides;
using System.Collections.Generic;

namespace Shop.WebApp.Models
{
    public class HomeViewModel
    {
        public List<SelectedListItem> Slides { get; set; }

        public List<ProductVm> FeaturedProducts { get; set; }

        public List<ProductVm> LatestProducts { get; set; }
    }
}
