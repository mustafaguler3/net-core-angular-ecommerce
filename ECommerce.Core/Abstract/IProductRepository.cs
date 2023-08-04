using System;
using Ecommerce.Core.Entities;

namespace ECommerce.Core.Abstract
{
	public interface IProductRepository
	{
		Task<Product> GetProductByIdAsync(int id);
		Task<IReadOnlyList<Product>> GetProductsAsync();
	}
}

