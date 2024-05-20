﻿using Microsoft.EntityFrameworkCore;
using Shop.Application.Catalog.Products.Dtos;
using Shop.Application.Dtos;
using Shop.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Shop.Application.Catalog.Products.Dtos.Public;
using System.Threading.Tasks;

namespace Shop.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        public readonly ShopDbContext _context;
        public PublicProductService(ShopDbContext context) {
            _context = context;
        }
        public async Task<PageResult<ProductViewModel>> GetAllByCategoryId(GetProductPagingRequest request)
        {

            var query = from p in _context.Products
                        join pt in _context.ProductTranslations on p.Id equals pt.ProductId
                        join pic in _context.ProductInCategories on p.Id equals pic.ProductId
                        join c in _context.Categories on pic.CategoryId equals c.Id
                        select new { p, pt, pic };
            

            if (request.CategoryId.HasValue &&  request.CategoryId.Value> 0)
            {
                query = query.Where(p => p.pic.CategoryId == request.CategoryId);
            }

            // 3.Paging
            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new ProductViewModel()
                {
                    Id = x.p.Id,
                    Name = x.pt.Name,
                    DateCreated = x.p.DateCreated,
                    Description = x.pt.Description,
                    Details = x.pt.Details,
                    LanguageId = x.pt.LanguageId,
                    OriginalPrice = x.p.OriginalPrice,
                    Price = x.p.Price,
                    SeoAlias = x.pt.SeoAlias,
                    SeoDescription = x.pt.SeoDescription,
                    SeoTitle = x.pt.SeoTitle,
                    Stock = x.p.Stock,
                    ViewCount = x.p.ViewCount
                }).ToListAsync();

            var pageResult = new PageResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data
            };

            return pageResult;
        }

       
    }
}
