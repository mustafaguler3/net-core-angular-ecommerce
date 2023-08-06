using System;
using ECommerce.Core.Entities;
using ECommerce.Core.Specifications;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Infrastructure.Data
{
	public class SpecificationEvaluator<T> where T : BaseEntity
	{
		public static IQueryable<T> GetQuery(IQueryable<T> input,ISpecification<T> spec)
		{
			var query = input;

			if(spec.Criteria != null)
			{
				query = query.Where(spec.Criteria);// p => p.ProductTypeId == id
			}

			if(spec.OrderBy != null)
			{
				query = query.OrderBy(spec.OrderBy);
			}

			if(spec.OrderByDescending != null)
			{
				query = query.OrderByDescending(spec.OrderByDescending);
			}

			if (spec.IsPagingEnabled)
			{
				query = query.Skip(spec.Skip).Take(spec.Take);
			}

			query = spec.Includes.Aggregate(query, (current, include) => current.Include(include));

			return query;
		}
	}
}

