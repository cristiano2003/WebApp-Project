using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Utilities.Exceptions
{
    public class ShopException : Exception
    {
        public ShopException()
        {
        }

        public ShopException(string message)
            : base(message)
        {
        }

        public ShopException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
