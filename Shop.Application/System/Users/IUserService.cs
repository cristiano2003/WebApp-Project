using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.ViewModels.Common;
using Shop.ViewModels.System.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.System.Users
{
    public interface IUserService
    {
         public Task<ApiResult<string>> Authenticate(LoginRequest request);
       

       public  Task<ApiResult<bool>> Register(RegisterRequest request);

        public Task<ApiResult<bool>> Update(Guid id, UserUpdateRequest request);

        public Task<ApiResult<PageResult<UserVm>>> GetUsersPaging(GetUserPagingRequest request);

        public Task<ApiResult<UserVm>> GetById(Guid id);
    }
}
