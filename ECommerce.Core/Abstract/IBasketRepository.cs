using System;
using ECommerce.Core.Entities;

namespace ECommerce.Core.Abstract
{
	public interface IBasketRepository
	{
		Task<Basket> GetBasketAsync(string basketId);
		Task<Basket> UpdateBasketAsync(Basket basket);
		Task<bool> DeleteBasketAsync(string basketId);
	}
}

