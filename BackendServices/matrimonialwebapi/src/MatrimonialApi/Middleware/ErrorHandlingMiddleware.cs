using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Threading.Tasks;
using System;
using System.Text.Json;
using System.Linq;

namespace MatrimonialApi.Middleware
{
    /// <summary>
    /// Middleware for handling unhandled exceptions and returning a standardized error response.
    /// </summary>
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ErrorHandlingMiddleware> _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorHandlingMiddleware"/> class.
        /// </summary>
        /// <param name="next">The next middleware in the pipeline.</param>
        /// <param name="logger">The logger.</param>
        public ErrorHandlingMiddleware(RequestDelegate next, ILogger<ErrorHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        /// <summary>
        /// Invokes the middleware to handle the request.
        /// </summary>
        /// <param name="context">The HTTP context.</param>
        public async Task Invoke(HttpContext context)
        {
             try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var requestDetails = GetRequestDetails(context);
                _logger.LogError(ex, "An unhandled exception has occurred. Request details: {RequestDetails}", requestDetails);
                await HandleExceptionAsync(context, ex);

            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            var result = JsonSerializer.Serialize(new { error = "An unexpected error occurred." });
            return context.Response.WriteAsync(result);
        }

        private string GetRequestDetails(HttpContext context)
        {
            var headers = context.Request.Headers.Select(h => $"{h.Key}: {h.Value}").ToList();
            var queryParams = context.Request.Query.Select(q => $"{q.Key}: {q.Value}").ToList();

            return JsonSerializer.Serialize(new
            {
                Method = context.Request.Method,
                Path = context.Request.Path,
                Headers = headers,
                QueryParams = queryParams
            });
        }
    }

}
