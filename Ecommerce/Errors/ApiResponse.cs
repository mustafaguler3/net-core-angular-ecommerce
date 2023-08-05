using System;
namespace Ecommerce.API.Errors
{
	public class ApiResponse
	{
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request",
                401 => "Authorized, you are not",
                404 => "Resource Not Found",
                500 => "Errors are the both to the dark side"
            };
        }

        public int StatusCode { get; set; }

        public string Message { get; set; }


	}
}

