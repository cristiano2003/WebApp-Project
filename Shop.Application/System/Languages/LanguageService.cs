using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Shop.Data.EF;
using Shop.ViewModels.Common;
using Shop.ViewModels.System.Languages;
using Shop.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.System.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly IConfiguration _config;
        private readonly ShopDbContext _context;

        public LanguageService(ShopDbContext context,
            IConfiguration config)
        {
            _config = config;
            _context = context;
        }

        public async Task<ApiResult<List<LanguageVm>>> GetAll()
        {
            var languages = await _context.Slides.Select(x => new LanguageVm()
            {
                Id = x.Id,
                Name = x.Name
            }).ToListAsync();
            return new ApiSuccessResult<List<LanguageVm>>(languages);
        }
    }
}