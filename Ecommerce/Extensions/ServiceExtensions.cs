using System;
using Ecommerce.API.Errors;
using Ecommerce.API.Mapper;
using Ecommerce.Infrastructure.Data;
using ECommerce.Core.Abstract;
using ECommerce.Infrastructure.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.API.Extensions
{
	public static class ServiceExtensions
	{
		public static IServiceCollection AddApplicationServices(this IServiceCollection services)
		{
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.Configure<ApiBehaviorOptions>(opt =>
            {
                opt.InvalidModelStateResponseFactory = context =>
                {
                    var errors = context.ModelState
                    .Where(i => i.Value.Errors.Count > 0)
                    .SelectMany(i => i.Value.Errors)
                    .Select(i => i.ErrorMessage).ToArray();

                    var errorResponse = new ApiValidationErrorResponse()
                    {
                        Errors = errors
                    };

                    return new BadRequestObjectResult(errorResponse);
                };
            });

            return services;
        }
	}
}

