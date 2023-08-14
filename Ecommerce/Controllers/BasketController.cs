using System;
using ECommerce.Core.Abstract;
using ECommerce.Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Controllers
{
    [Route("api/baskets")]
    [ApiController]
	public class BasketController : ControllerBase
	{
		private readonly IBasketRepository _basketRepository;

        public BasketController(IBasketRepository basketRepository)
        {
            _basketRepository = basketRepository;
        }

        [HttpGet]
        public async Task<ActionResult<Basket>> GetBasketById(string id)
        {
            var basket = await _basketRepository.GetBasketAsync(id);

            return Ok(basket ?? new Basket(id));
        }


        [HttpPost]
        public async Task<ActionResult<Basket>> UpdateBasket(Basket basket)
        {
            var updated = await _basketRepository.UpdateBasketAsync(basket);

            return Ok(updated);
        }

        [HttpDelete]
        public async Task DeleteBasketAsync(string id)
        {
            await _basketRepository.DeleteBasketAsync(id);
        }
    }
}

