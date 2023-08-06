using System;
using Ecommerce.Core.Entities;

namespace ECommerce.Core.Specifications
{
	public class ProductWithFiltersForCountSpecification : Specification<Product>
	{
		public ProductWithFiltersForCountSpecification(ProductSpecParams productParams):base(i=>(!productParams.BrandId.HasValue || i.ProductBrandId == productParams.BrandId) && (!productParams.TypeId.HasValue || i.ProductTypeId == productParams.TypeId))
		{
		}
	}
}

