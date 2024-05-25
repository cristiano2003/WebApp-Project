using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Shop.ViewModels.Catalog.Categories;
using Shop.ViewModels.Common;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shop.AdminApp.Services
{

        public class CategoryApiClient : BaseApiClient, ICategoryApiClient
        {
            public CategoryApiClient(IHttpClientFactory httpClientFactory,
                       IHttpContextAccessor httpContextAccessor,
                        IConfiguration configuration)
                : base(httpClientFactory, httpContextAccessor, configuration)
            {
            }

            public async Task<List<CategoryVm>> GetAll(string languageId)
            {
            return await GetListAsync<CategoryVm>("/api/categories?languageId=" + languageId);
            }
        }
    
}
