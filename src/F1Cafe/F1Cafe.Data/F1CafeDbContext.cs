using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace F1Cafe.Data
{
    public class F1CafeDbContext : IdentityDbContext
    {
        public F1CafeDbContext(DbContextOptions<F1CafeDbContext> options)
            : base(options)
        {
        }
    }
}
