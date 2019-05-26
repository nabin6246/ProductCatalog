using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.Models;
using ProductCatalog.Domain.Repositories;
using ProductCatalog.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.Persistence.Repositories
{
    public class ProductRepository:BaseRepository,IProductRepository
    {
        public ProductRepository(AppDbContext context):base(context)
        {

        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Products.Include(p => p.Category).ToListAsync();
        }
    }
}
