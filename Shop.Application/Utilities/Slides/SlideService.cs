
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Shop.Application.Utilities.Slides;
using Shop.Data.EF;
using Shop.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly ShopDbContext _context;

        public SlideService(ShopDbContext context)
        {
            _context = context;
        }

        public async Task<List<SelectedListItem>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SelectedListItem()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}