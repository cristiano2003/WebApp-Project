using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Application.System.Users;
using Shop.ViewModels.Catalog.Products;
using Shop.ViewModels.System.Users;
using System;
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

            var result = await _userService.Authenticate(request);

            if (string.IsNullOrEmpty(result.ResultObj))
            {
                return BadRequest("Username or Password is incorrect");
            }


            return Ok(result);
        }


        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Register(request);

            if (!result.IsSucceeded)
            {
                return BadRequest(result.Message);
            }


            return Ok();
        } 
        
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] UserUpdateRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await _userService.Update(id, request);
            if (!result.IsSucceeded)
            {
                return BadRequest(result.Message);
            }
            return Ok(result);
        }

      
        [HttpGet("paging")]
        public async Task<ActionResult> GetAllPaging( [FromQuery] GetUserPagingRequest request)
        {
            var product = await _userService.GetUsersPaging(request);

            return Ok(product);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            var user= await _userService.GetById(id);

            return Ok(user);
        }


    }
}
