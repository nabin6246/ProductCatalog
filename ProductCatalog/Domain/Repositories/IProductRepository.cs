﻿using ProductCatalog.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}
