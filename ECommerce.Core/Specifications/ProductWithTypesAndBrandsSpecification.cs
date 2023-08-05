using System;
using Ecommerce.Core.Entities;

namespace ECommerce.Core.Specifications
{
	public class ProductWithTypesAndBrandsSpecification : Specification<Product>
	{
		public ProductWithTypesAndBrandsSpecification()
		{
			AddInclude(x => x.ProductType);
			AddInclude(x => x.ProductBrand);
		}
		public ProductWithTypesAndBrandsSpecification(int id):base(x=>x.Id==id)
		{
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
        }
	}
}

