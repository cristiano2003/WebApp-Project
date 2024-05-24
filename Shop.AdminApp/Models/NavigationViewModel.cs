using Shop.ViewModels.System.Languages;
using System.Collections.Generic;

namespace Shop.AdminApp.Models
{
    public class NavigationViewModel
    {
        public List<LanguageVm> Languages { get; set; }

        public string CurrentLanguageId { get; set; }
    }
}
