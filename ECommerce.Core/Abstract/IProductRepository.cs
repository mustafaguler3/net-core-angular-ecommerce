using System;
using Ecommerce.Core.Entities;
using ECommerce.Core.Entities;

namespace ECommerce.Core.Abstract
{
	public interface IProductRepository
	{
		Task<Product> GetProductByIdAsync(int id);
		Task<IReadOnlyList<Product>> GetProductsAsync();
		Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync();
        Task<IReadOnlyList<ProductType>> GetProductTypesAsync();
    }
}

