using System;
using AutoMapper;
using Ecommerce.API.Dtos;
using Ecommerce.Core.Entities;
using ECommerce.Core.Abstract;
using ECommerce.Core.Entities;
using ECommerce.Core.Specifications;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IGenericRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public ProductsController(IGenericRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetProducts(string sort,int? brandId,int? typeId)
        {
            var spec = new ProductWithTypesAndBrandsSpecification(sort,brandId,typeId);

            var products = await _productRepository.ListAsync(spec);

            return Ok(_mapper.Map<List<ProductDto>>(products));
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var spec = new ProductWithTypesAndBrandsSpecification(id);

            return await _productRepository.GetProductByIdAsync(id);
        }

        [HttpGet("brands")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductBrands()
        {
            return Ok(await _productRepository.GetProductBrandsAsync());
        }

        [HttpGet("types")]
        public async Task<ActionResult<IReadOnlyList<ProductBrand>>> GetProductTypes()
        {
            return Ok(await _productRepository.GetProductTypesAsync());
        }
    }
}

