using System;
using Ecommerce.Infrastructure.Data;
using ECommerce.Core.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private readonly StoreContext _context;

        public GenericRepository(StoreContext context)
        {
            _context = context;
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }
    }
}

