﻿using Microsoft.AspNetCore.Mvc.RazorPages;
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
         public Task<string> Authenticate(LoginRequest request);
       

       public  Task<bool> Register(RegisterRequest request);

        public Task<PageResult<UserVm>> GetUsersPaging(GetUserPagingRequest request);
    }
}
