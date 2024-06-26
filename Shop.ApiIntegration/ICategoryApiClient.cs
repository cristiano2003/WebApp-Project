﻿using Shop.ViewModels.Catalog.Categories;
using Shop.ViewModels.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Shop.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryVm>> GetAll(string languageId);

        Task<CategoryVm> GetById(string languageId, int id);
    }
}
