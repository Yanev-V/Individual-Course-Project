using F1Cafe.Data.Configurations;
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

        public DbSet<Car> Cars { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Driver> Drivers { get; set; }

        public DbSet<DriversRaces> DriversRaces { get; set; }

        public DbSet<News> News { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Statistics> Statistics { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<DbExceptionLog> DbExceptionLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CarConfiguration());
            builder.ApplyConfiguration(new CommentConfiguration());
            builder.ApplyConfiguration(new DriverConfiguration());
            builder.ApplyConfiguration(new DriversRacesConfiguration());
            builder.ApplyConfiguration(new NewsConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new RaceConfiguration());
            builder.ApplyConfiguration(new StatisticsConfiguration());
            builder.ApplyConfiguration(new TeamConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
