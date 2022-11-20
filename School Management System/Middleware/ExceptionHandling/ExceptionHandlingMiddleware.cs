using System.Net;
namespace School_Management_System.Middleware.ExceptionHandling
{
    public class ExceptionHandlingMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
			try
			{
				await next(context);
			}
			catch (DomainServiceException ex)
			{
				context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
				context.Response.WriteAsync(ex.Message);
			}
            catch (DomainNotFoundException ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                context.Response.WriteAsync(ex.Message);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Response.WriteAsync(ex.Message);
            }
        }
    }
}
