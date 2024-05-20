﻿using Shop.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Application.Catalog.Products.Dtos.Public
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int? CategoryId { get; set; }
    }
}
