using F1Cafe.Data.Seeding;
using F1Cafe.Web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace F1Cafe.Web.Extensions.Middlewares
{
    public class SeedDatabaseMiddleware
    {
        private readonly RequestDelegate next;

        public SeedDatabaseMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext, IServiceProvider svc)
        {
            var dbContext = svc.GetRequiredService<F1CafeDbContext>();

            F1CafeDbContextSeeder.Seed(dbContext, svc);

            await this.next(httpContext);
        }
    }
}
