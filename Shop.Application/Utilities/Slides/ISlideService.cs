using Shop.ViewModels.System.Languages;
using Shop.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Utilities.Slides
{
   public interface ISlideService
    {
        Task<List<SelectedListItem>> GetAll();
    }
}
