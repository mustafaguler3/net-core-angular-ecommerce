using System;
using Ecommerce.Core.Entities;

namespace ECommerce.Core.Specifications
{
	public class ProductWithFiltersForCountSpecification : Specification<Product>
	{
		public ProductWithFiltersForCountSpecification(ProductSpecParams productParams):base(i=> (string.IsNullOrEmpty(productParams.Search) || i.Name.ToLower().Contains(productParams.Search)) && (!productParams.BrandId.HasValue || i.ProductBrandId == productParams.BrandId) && (!productParams.TypeId.HasValue || i.ProductTypeId == productParams.TypeId))
		{
		}
	}
}

