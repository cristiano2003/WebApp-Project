using Shop.Application.Catalog.Products.Dtos;
using Shop.Application.Catalog.Products.Dtos.Public;
using Shop.Application.Dtos;
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
