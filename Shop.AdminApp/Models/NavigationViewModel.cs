using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.ViewModels.System.Languages;
using Shop.ViewModels.Utilities.Slides;
using System.Collections.Generic;

namespace Shop.AdminApp.Models
{
    public class NavigationViewModel
    {
        public List<SelectListItem> Languages { get; set; }

        public string CurrentLanguageId { get; set; }

        public string ReturnUrl { get; set; }  
    }
}
