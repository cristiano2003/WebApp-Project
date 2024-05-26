using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.Catalog.Products;
using Shop.ViewModels.Catalog.Products;
using Shop.ViewModels.ProductImages;
using System.Threading.Tasks;

namespace Shop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
       

        public ProductsController(IProductService productService)
        {
            _productService = productService;
            
        }


        // http://localhost:port/product/public-paging
        [HttpGet("paging")]
        public async Task<ActionResult> GetAllPaging([FromQuery] GetManageProductPagingRequest request)
        {
            var product = await _productService.GetAllPaging(request);

            return Ok(product);
        }

        //https://localhost:port/Product/Id
        [HttpGet("{productId}/{languageId}")]
        public async Task<ActionResult> GetById(int productId, string languageId)
        {
            var product = await _productService.GetById(productId, languageId);

            if (product == null)
                return BadRequest("cannot find the product");

            return Ok(product);
        }


        [HttpGet("featured/{languageId}/{take}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetFeaturedProducts(int take, string languageId)
        {
            var products = await _productService.GetFeaturedProducts(languageId, take);
            return Ok(products);
        }

        [HttpPost]
        [Consumes("multipart/form-data")] 
        public async Task<ActionResult> Create([FromForm] ProductCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var productId = await _productService.Create(request);

            if (productId == 0)
                return BadRequest();

            var product = await _productService.GetById(productId, request.LanguageId);

            return CreatedAtAction(nameof(GetById), new { id = productId }, product); 
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromForm] ProductUpdateRequest request)
        {
             
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var affectedResult = await _productService.Update(request);

            if (affectedResult == 0)
                return BadRequest();

            return Ok();
        }

        [HttpDelete("ProductId")]
        public async Task<ActionResult> Delete(int productId)
        {
            var affectedResult = await _productService.Delete(productId);

            if (affectedResult == 0)
                return BadRequest();

            return Ok();
        }

        [HttpPatch("{productId}/{newPrice}")]
        public async Task<ActionResult> UpdatePrice( int productId, decimal newPrice)
        {
            var isSuccessful = await _productService.UpdatePrice(productId, newPrice);

            if (isSuccessful == true)
                return Ok();

            return BadRequest();
        }
        
        //Images
        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImage(int productId, [FromForm] ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _productService.AddImage(productId, request);
            if (imageId == 0)
                return BadRequest();

            var image = await _productService.GetImageById(imageId);

            return CreatedAtAction(nameof(GetImageById), new { id = imageId }, image);
        }

        [HttpPut("{productId}/images/{imageId}")]
        [Authorize]
        public async Task<IActionResult> UpdateImage(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.UpdateImage(imageId, request);
            if (result == 0)
                return BadRequest();

            return Ok();
        }


        [HttpDelete("{productId}/images/{imageId}")]
        [Authorize]
        public async Task<IActionResult> RemoveImage(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();

            return Ok();
        }

        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById( int imageId)
        {
            var image = await _productService.GetImageById(imageId);
            if (image == null)
                return BadRequest("Cannot find product");
            return Ok(image);
        }

        [HttpPut("{id}/categories")]
        public async Task<IActionResult> CategoryAssign(int id, [FromBody] CategoryAssignRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _productService.CategoryAssign(id, request);
            if (!result.IsSucceeded)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }


    }
}
