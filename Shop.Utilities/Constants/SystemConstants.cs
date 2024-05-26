using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Shop.Utilities.Constants
{
    public class SystemConstants
    {
        public const string MainConnectString = "ShopDb";

        public class AppSettings
        {
            public const string DefaultLanguageId = "DefaultLanguageId";
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
        }

        public class ProductSettings
        {
            public const int NumberOfFeaturedProducts = 4;
        }
    }
}
