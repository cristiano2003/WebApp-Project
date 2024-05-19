using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
    }
}
