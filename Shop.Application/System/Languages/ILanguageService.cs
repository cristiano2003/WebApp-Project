
using Shop.ViewModels.Common;
using Shop.ViewModels.System.Languages;
using Shop.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.System.Languages
{
    public interface ILanguageService
    {
        Task<ApiResult<List<SelectedListItem>>> GetAll();
    }
}