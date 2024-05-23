using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.ViewModels.Common
{
    public class PageResult<T> : PageResultBase
    {
        public List<T> Items { get; set; }

   
    }
}
