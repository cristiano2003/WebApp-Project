using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.System.Users;
using Shop.ViewModels.Catalog.Products;
using Shop.ViewModels.System.Users;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace Shop.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly IUserService _userService; 
        public UsersController(IUserService userService) 
        {
            _userService = userService;
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromBody] LoginRequest request)
        {
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            var resultToken = await _userService.Authenticate(request);

            if (string.IsNullOrEmpty(resultToken))
            {
                return BadRequest("Username or Password is incorrect");
            }


            return Ok(resultToken);
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Register(request);

            if (!result)
            {
                return BadRequest("Register is not successful");
            }


            return Ok();
        }

      
        [HttpGet("paging")]
        public async Task<ActionResult> GetAllPaging( [FromQuery] GetUserPagingRequest request)
        {
            var product = await _userService.GetUsersPaging(request);

            return Ok(product);
        }




    }
}
