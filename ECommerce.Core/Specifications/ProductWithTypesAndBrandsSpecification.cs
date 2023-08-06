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

        public ProductWithTypesAndBrandsSpecification(string sort)
        {
            AddInclude(x => x.ProductType);
            AddInclude(x => x.ProductBrand);
            AddOrderBy(x => x.Name);

            if (!string.IsNullOrEmpty(sort))
            {
                switch (sort)
                {
                    case "priceAsc":
                        AddOrderBy(x => x.Price);
                        break;
                    case "priceDesc":
                        AddOrderByDescending(x => x.Price);
                        break;
                    default:
                        AddOrderBy(x => x.Name);
                        break;
                }
            }
        }
    }
}

