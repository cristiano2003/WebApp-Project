﻿using Shop.Application.Catalog.Products.Dtos;
using Shop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        public PageViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pagesize)
        {
            throw new NotImplementedException();
        }
    }
}
