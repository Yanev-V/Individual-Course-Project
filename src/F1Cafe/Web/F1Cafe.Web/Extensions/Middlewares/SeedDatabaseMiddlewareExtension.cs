using Microsoft.AspNetCore.Builder;

namespace F1Cafe.Web.Extensions.Middlewares
{
    public static class SeedDatabaseMiddlewareExtension
    {
        public static IApplicationBuilder UseSeedDatabaseMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SeedDatabaseMiddleware>();
        }
    }
}
