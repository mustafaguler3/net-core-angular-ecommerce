using System;
namespace ECommerce.Core.Entities
{
	public class Basket
	{
		public Basket()
		{

		}

		public Basket(string id)
		{
			this.Id = id;
		}

		public string Id { get; set; }
		public List<BasketItem> Items { get; set; } = new List<BasketItem>();
	}
}

