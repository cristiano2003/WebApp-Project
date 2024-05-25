using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Catalog.Categories;
using Shop.Application.Catalog.Products;
using System.Threading.Tasks;

namespace Shop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService productService)
        {
            _categoryService = productService;

        }


        [HttpGet]
        public async Task<ActionResult> GetAll(string languageId)
        {
            var product = await _categoryService.GetAll(languageId);

            return Ok(product);
        }
    }
}
