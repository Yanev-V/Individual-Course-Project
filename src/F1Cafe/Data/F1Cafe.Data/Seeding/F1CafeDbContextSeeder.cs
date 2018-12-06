using F1Cafe.Common;
using F1Cafe.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace F1Cafe.Data.Seeding
{
    public class F1CafeDbContextSeeder
    {
        public static void Seed(F1CafeDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            if (serviceProvider == null)
            {
                throw new ArgumentNullException(nameof(serviceProvider));
            }

            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            Seed(dbContext, roleManager);
        }

        public static void Seed(F1CafeDbContext dbContext, RoleManager<IdentityRole> roleManager)
        {
            if (dbContext == null)
            {
                throw new ArgumentNullException(nameof(dbContext));
            }

            if (roleManager == null)
            {
                throw new ArgumentNullException(nameof(roleManager));
            }

            SeedRoles(roleManager);
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            SeedRole(GlobalConstants.AdministratorRoleName, roleManager);
            SeedRole(GlobalConstants.UserRoleName, roleManager);
        }

        private static void SeedRole(string roleName, RoleManager<IdentityRole> roleManager)
        {
            var role = roleManager.FindByNameAsync(roleName).GetAwaiter().GetResult();

            if (role == null)
            {
                var result = roleManager.CreateAsync(new IdentityRole(roleName)).GetAwaiter().GetResult();

                if (!result.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, result.Errors.Select(e => e.Description)));
                }
            }
        }
    }
}
