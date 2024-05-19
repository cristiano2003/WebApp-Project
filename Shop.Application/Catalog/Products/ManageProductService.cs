using Shop.Application.Catalog.Products.Dtos;
using Shop.Application.Dtos;
using Shop.Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Catalog.Products
{
    public class ManageProductService : IManageProductService
    {
        private readonly ShopDbContext _context;
        public ManageProductService(ShopDbContext context) 
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PageViewModel<ProductViewModel>> GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public async Task<int> Update(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
