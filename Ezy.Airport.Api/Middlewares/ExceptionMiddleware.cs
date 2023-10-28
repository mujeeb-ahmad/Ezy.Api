using Ezy.Airport.Api.Error;
using System.Net;

namespace Ezy.Airport.Api.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionMiddleware> logger;
        private readonly IHostEnvironment env;
        public ExceptionMiddleware(RequestDelegate next,
                                    ILogger<ExceptionMiddleware> logger,
                                    IHostEnvironment env)
        {
            this.env = env;
            this.next = next;
            this.logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                ApiError response = HandleApiError(ex);
                context.Response.StatusCode = response.ErrorCode;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsync(response.ToString());
            }
        }
        private ApiError HandleApiError(Exception ex)
        {
            ApiError response;
            HttpStatusCode statusCode;
            string message;
            var exceptionType = ex.GetType();

            if (exceptionType == typeof(UnauthorizedAccessException))
            {
                statusCode = HttpStatusCode.Forbidden;
                message = "You are not authorized";
            }
            else if (exceptionType == typeof(KeyNotFoundException))
            {
                statusCode = HttpStatusCode.BadRequest;
                message = "You are not authorized";
            }
            else
            {
                statusCode = HttpStatusCode.InternalServerError;
                message = "Some unknown error occoured";
            }
            if (env.IsDevelopment())
            {
                response = new ApiError((int)statusCode, ex.Message, ex.StackTrace);
            }
            else
            {
                response = new ApiError((int)statusCode, message);
            }
            logger.LogError(ex, ex.Message);
            return response;
        }
    }
}
