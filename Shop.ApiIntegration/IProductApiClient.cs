using Shop.ViewModels.Catalog.Products;
using Shop.ViewModels.Common;
using System;
using System.Threading.Tasks;

namespace Shop.ApiIntegration
{
    public interface IProductApiClient
    {
        Task<PageResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);

        Task<ApiResult<bool>> CategoryAssign(int id, CategoryAssignRequest request);

        Task<ProductVm> GetById(int id, string languageId);
    }
}
