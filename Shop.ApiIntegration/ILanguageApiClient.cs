using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.ViewModels.Common;
using Shop.ViewModels.System.Languages;
using Shop.ViewModels.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.ApiIntegration
{
    public interface ILanguageApiClient
    {
        Task<ApiResult<List<LanguageVm>>> GetAll();
    }
}
