using System;
using System.Collections.Generic;
using System.Text;
using F1Cafe.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace F1Cafe.Web.Data
{
    public class F1CafeDbContext : IdentityDbContext<F1CafeUser>
    {
        public F1CafeDbContext(DbContextOptions<F1CafeDbContext> options)
            : base(options)
        {
        }
    }
}
