using SchoolOfDevs.Exceptions;
using System.Net;
using System.Text.Json;

namespace SchoolOfDevs.Middleware
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception error)
            {
                var response = context.Response;
                response.ContentType= "application/json";
                response.StatusCode = error switch
                {
                    BadRequestException => (int)HttpStatusCode.BadRequest, // custom application eror
                    KeyNotFoundException => (int)HttpStatusCode.NotFound, // not faund error    
                    ForbiddenException => (int)HttpStatusCode.Forbidden, // unhandled error
                    _ => (int)HttpStatusCode.InternalServerError,
                };
                
                var result = JsonSerializer.Serialize(new { message = error?.Message });
                await response.WriteAsync(result);
            }
        }
    }
}
