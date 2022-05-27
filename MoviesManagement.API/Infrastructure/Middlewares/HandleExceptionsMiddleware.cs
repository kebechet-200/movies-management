using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using MoviesManagement.API.Global_Exceptions;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace MoviesManagement.API.Infrastructure.Middlewares
{
    public class HandleExceptionsMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<HandleExceptionsMiddleware> _logger;
        private const int serverErrors = 500;
        private const int clientErrors = 400;
        private const int succeed = 200;

        public HandleExceptionsMiddleware(RequestDelegate next, ILogger<HandleExceptionsMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                if (context.Response.StatusCode >= serverErrors && context.Response.StatusCode < 600)
                    _logger.LogError($"{context.Response.StatusCode} server error occured");

                if (context.Response.StatusCode >= clientErrors && context.Response.StatusCode < 500)
                    _logger.LogWarning($"{context.Response.StatusCode} client error occured");

                if (context.Response.StatusCode >= succeed && context.Response.StatusCode < 300)
                    _logger.LogInformation($"{context.Response.StatusCode} Succeed!");

                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var error = new ApiExceptionHandling(context, ex);
            var result = JsonConvert.SerializeObject(error);

            context.Response.Clear(); //გავასუფთაოთ output
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = error.Status.Value;

            await context.Response.WriteAsync(result);
        }
    }
}
