using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Diagnostics;
using Volo.Abp.DependencyInjection;

namespace Demo.Shared
{
    public class CustomMiddleWare : IMiddleware, ITransientDependency
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var instance = context.RequestServices.GetRequiredService<ShouldBeScoped>();
            Debug.WriteLine($"CustomMiddleWare: {instance.GetHashCode()}");
            await next(context);
        }
    }
}
