using Microsoft.AspNetCore.Mvc;
using Shop.ViewModels.Common;
using System.Threading.Tasks;

namespace Shop.AdminApp.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PageResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
