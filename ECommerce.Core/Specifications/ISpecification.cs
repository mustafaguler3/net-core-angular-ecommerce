﻿using System;
using System.Linq.Expressions;

namespace ECommerce.Core.Specifications
{
	public interface ISpecification<T>
	{
		Expression<Func<T,bool>> Criteria { get; }

		List<Expression<Func<T,object>>> Includes { get; }
	}
}
