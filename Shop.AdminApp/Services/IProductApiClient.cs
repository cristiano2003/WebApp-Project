using Shop.ViewModels.Catalog.Products;
using Shop.ViewModels.Common;
using System.Threading.Tasks;

namespace Shop.AdminApp.Services
{
    public interface IProductApiClient
    {
        Task<PageResult<ProductVm>> GetPagings(GetManageProductPagingRequest request);

        Task<bool> CreateProduct(ProductCreateRequest request);
    }
}
