using System;
using Ecommerce.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ECommerce.Infrastructure.Data
{
    public class StoreContextFactory : IDesignTimeDbContextFactory<StoreContext>
    {
        public StoreContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<StoreContext>();
            builder.UseSqlite("Data source=ecommerce.db");

            return new StoreContext(builder.Options);
        }
    }
}

