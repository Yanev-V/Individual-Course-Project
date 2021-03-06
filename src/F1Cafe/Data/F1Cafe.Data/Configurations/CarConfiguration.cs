﻿using F1Cafe.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace F1Cafe.Data.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder
                 .HasOne(c => c.Driver)
                 .WithOne(d => d.Car)
                 .HasForeignKey<Driver>(d => d.CarId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder
                 .HasOne(c => c.Team)
                 .WithMany(t => t.Cars)
                 .HasForeignKey(c => c.TeamId)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
