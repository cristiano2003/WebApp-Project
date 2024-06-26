﻿using Microsoft.AspNetCore.Http;
using Shop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.ViewModels.Catalog.Products
{
    public class ProductUpdateRequest
    {
        public int Id { set; get; }

        public string Name { set; get; }
        public string Description { set; get; }
        public string Details { set; get; }
        public string SeoDescription { set; get; }
        public string SeoTitle { set; get; }

        public string SeoAlias { get; set; }
        public string LanguageId { set; get; }

        public bool IFeatured { get; set; }

        public IFormFile ThumbnailImage { get; set; }

    }
}
