using Shop.ViewModels.Catalog.Categories;
using Shop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.AdminApp.Services
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);
    }
}
