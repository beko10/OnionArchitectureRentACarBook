using OnionArchitectureRentACarBook.Application.Common.Exceptions;

public sealed class ExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionHandlingMiddleware> _log;

    public ExceptionHandlingMiddleware(RequestDelegate next, ILogger<ExceptionHandlingMiddleware> log)
    {
        _next = next; 
        _log = log;
    }

    public async Task InvokeAsync(HttpContext ctx)
    {
        try
        {
            await _next(ctx);
        }
        catch (AppException appEx)              
        {
            await HandleAppExceptionAsync(ctx, appEx);
        }
        catch (Exception ex)                    
        {
            _log.LogError(ex, "Unhandled error {Path}", ctx.Request.Path);
            await WriteProblemAsync(ctx, 500, "Internal Server Error");
        }
    }

    private Task HandleAppExceptionAsync(HttpContext ctx, AppException ex)
    {
        _log.LogWarning(ex, "Handled {Exception}", ex.GetType().Name);
        return WriteProblemAsync(ctx, ex.StatusCode, ex.Message, ex.ErrorCode);
    }

    private static Task WriteProblemAsync(HttpContext ctx, int status, string message, string? code = null)
    {
        ctx.Response.StatusCode = status;
        ctx.Response.ContentType = "application/json";

        return ctx.Response.WriteAsJsonAsync(new
        {
            type = $"https://httpstatuses.com/{status}",
            title = message,
            status,
            errorCode = code,
            traceId = ctx.TraceIdentifier
        });
    }
}

