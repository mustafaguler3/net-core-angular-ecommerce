using System;
using Ecommerce.Core.Entities;
using Ecommerce.Infrastructure.Data;
using ECommerce.Core.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;

        public ProductRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products.ToListAsync();
        }
    }
}

