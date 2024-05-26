using Shop.ViewModels.System.Languages;
using Shop.ViewModels.Utilities.Slides;
using System.Collections.Generic;

namespace Shop.AdminApp.Models
{
    public class NavigationViewModel
    {
        public List<SlideVm> Languages { get; set; }

        public string CurrentLanguageId { get; set; }
    }
}
