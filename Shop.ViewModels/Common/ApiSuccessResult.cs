using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.ViewModels.Common
{
    public  class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultObj) 
        {
            IsSucceeded = true;
            ResultObj = resultObj;
        }

        public ApiSuccessResult()
        {
            IsSucceeded = true;
        }
    }
}
