using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Shop.Data.Entities;
using Shop.ViewModels.Catalog.Products;
using Shop.ViewModels.Common;
using Shop.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.System.Users
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _configuration;
       
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager,
            IConfiguration config)
            
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            
            _configuration = config;
        }

        public async Task<ApiResult<string>> Authenticate(LoginRequest request)
        {
            {
                var user = await _userManager.FindByNameAsync(request.UserName);
                if (user == null) return null;

                var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, true);
                if (!result.Succeeded)
                {
                    return new ApiErrorResult<string>("Login Info is incorrect");
                }
                var roles = await _userManager.GetRolesAsync(user);
                var claims = new[]
                {
                    new Claim(ClaimTypes.Email,user.Email),
                    new Claim(ClaimTypes.GivenName, user.FirstName),
                    new Claim(ClaimTypes.Role, string.Join(";", roles)),
                    new Claim(ClaimTypes.Name, request.UserName)
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Tokens:Key"]));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(_configuration["Tokens:Issuer"],
                    _configuration["Tokens:Issuer"],
                    claims,
                    expires: DateTime.Now.AddHours(3),
                    signingCredentials: creds);

                return new ApiSuccessResult<string>(new JwtSecurityTokenHandler().WriteToken(token));
            }
        }

        public async Task<ApiResult<UserVm>> GetById(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return new ApiErrorResult<UserVm>("User does not exist");
            }

            var userVm = new UserVm()
            { 
            Email = user.Email,
            UserName = user.UserName,
             PhoneNumber = user.PhoneNumber,
            FirstName=user.FirstName,
            LastName=user.LastName,
            Dob = user.Dob,
            Id = user.Id};

            return new ApiSuccessResult<UserVm>(userVm);

        }


        public async Task<ApiResult<PageResult<UserVm>>> GetUsersPaging(GetUserPagingRequest request)
        {
            var query = _userManager.Users;
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.UserName.Contains(request.Keyword)
                || x.PhoneNumber.Contains(request.Keyword));
            }

            int totalRow = await query.CountAsync();
            var data = await query.Skip((request.PageIndex - 1) * request.PageSize)
                .Take(request.PageSize)
                .Select(x => new UserVm()
                {
                    Id = x.Id,
                   Email  = x.Email,
                   PhoneNumber = x.PhoneNumber,
                   UserName = x.UserName,  
                   FirstName = x.FirstName,
                   LastName = x.LastName
                }).ToListAsync();

            var pageResult = new PageResult<UserVm>()
            {
                TotalRecords = totalRow,
                Items = data,
                PageIndex = request.PageIndex,
                PageSize = request.PageSize
            };

            return new ApiSuccessResult<PageResult<UserVm>>(pageResult);
        }

        public async Task<ApiResult<bool>> Register(RegisterRequest request)
        {
            var user = await _userManager.FindByNameAsync(request.UserName);
            if (user != null)
                 {
                return new ApiErrorResult<bool>("UserName existed");

            }

            if (await _userManager.FindByEmailAsync(request.Email) != null)
            {
                return new ApiErrorResult<bool>("Email existed");
            }  

           user = new AppUser()
            {
                Dob = request.Dob,
                Email = request.Email,
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                PhoneNumber = request.PhoneNumber
            };
            var result = await _userManager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<bool>();

             }
            return new ApiErrorResult<bool>("Register failed");
        }

        public async Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request)
       {

            if (await _userManager.Users.AnyAsync(x=>x.Email==request.Email && x.Id != id))
            {
                return new ApiErrorResult<bool>("Email existed");
            }

            var user = await _userManager.FindByIdAsync(id.ToString());
            

            user.Dob = request.Dob;
            user.Email = request.Email;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.PhoneNumber = request.PhoneNumber;
            
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return new ApiSuccessResult<bool>();

            }
            return new ApiErrorResult<bool>("Update failed");
        }

    }
}
