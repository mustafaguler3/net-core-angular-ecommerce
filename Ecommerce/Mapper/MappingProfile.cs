using System;
using AutoMapper;
using Ecommerce.API.Dtos;
using Ecommerce.Core.Entities;

namespace Ecommerce.API.Mapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Product, ProductDto>()
				.ForMember(i => i.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
				.ForMember(i => i.ProductType, o => o.MapFrom(s => s.ProductType.Name));

        }
	}
}

