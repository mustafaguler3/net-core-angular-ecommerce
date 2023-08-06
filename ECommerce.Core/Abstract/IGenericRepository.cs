using System;
using ECommerce.Core.Entities;
using ECommerce.Core.Specifications;

namespace ECommerce.Core.Abstract
{
	public interface IGenericRepository<T> where T : BaseEntity
	{
		Task<T> GetByIdAsync(int id);
		Task<IReadOnlyList<T>> ListAllAsync();
		Task<T> GetEntityWithSpec(ISpecification<T> spec);
		Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
		Task<int> CountAsync(ISpecification<T> spec);
	}
}

