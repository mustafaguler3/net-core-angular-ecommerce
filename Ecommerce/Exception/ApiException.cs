using System;
using Ecommerce.API.Errors;

namespace Ecommerce.API.Exception
{
	public class ApiException : ApiResponse
	{
		public string Details { get; set; }

		public ApiException(int statusCode,string message = null,string details=null):base(statusCode,message)
		{
			Details = details;
		}
	}
}

