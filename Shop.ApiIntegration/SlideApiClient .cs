using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Shop.ViewModels.Catalog.Categories;
using Shop.ViewModels.Common;
using Shop.ViewModels.System.Languages;
using Shop.ViewModels.Utilities.Slides;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Shop.ApiIntegration
{

    public class SlideApiClient : BaseApiClient, ISlideApiClient
    {
        public SlideApiClient(IHttpClientFactory httpClientFactory,
                   IHttpContextAccessor httpContextAccessor,
                    IConfiguration configuration)
            : base(httpClientFactory, httpContextAccessor, configuration)
        {
        }
           public async Task<List<SlideVm>> GetAll()
            {
                return await GetListAsync<SlideVm>("/api/slides");
            }
        
    }

}
