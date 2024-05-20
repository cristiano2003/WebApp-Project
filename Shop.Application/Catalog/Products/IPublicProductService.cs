
using Shop.ViewModels.Catalog.Products;
using Shop.ViewModels.Catalog.Products.Public;
using Shop.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        public Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
