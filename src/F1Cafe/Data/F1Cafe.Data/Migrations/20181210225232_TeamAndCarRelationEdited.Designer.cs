﻿// <auto-generated />
using System;
using F1Cafe.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace F1Cafe.Data.Migrations
{
    [DbContext(typeof(F1CafeDbContext))]
    [Migration("20181210225232_TeamAndCarRelationEdited")]
    partial class TeamAndCarRelationEdited
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("F1Cafe.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Chassis")
                        .IsRequired();

                    b.Property<int>("DriverId");

                    b.Property<string>("FrontImage");

                    b.Property<string>("PowerUnit")
                        .IsRequired();

                    b.Property<string>("RearImage");

                    b.Property<string>("SideImage");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("DriverId")
                        .IsUnique();

                    b.HasIndex("TeamId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .IsRequired();

                    b.Property<DateTime>("CommentedOn");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int>("NewsId");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("NewsId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.DbExceptionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Action");

                    b.Property<string>("Area");

                    b.Property<string>("Controller");

                    b.Property<string>("ExeptionType")
                        .IsRequired();

                    b.Property<DateTime>("LogTime");

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("Page");

                    b.Property<string>("StackTrace")
                        .IsRequired();

                    b.Property<string>("User")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("DbExceptionLogs");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate");

                    b.Property<int>("CarId");

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<int>("DriverNumber");

                    b.Property<DateTime>("F1StartYear");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("ImageUrl");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("StatisticsId");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("StatisticsId")
                        .IsUnique();

                    b.HasIndex("TeamId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.DriversRaces", b =>
                {
                    b.Property<int>("DriverId");

                    b.Property<int>("RaceId");

                    b.Property<int>("Laps");

                    b.Property<int>("Position");

                    b.Property<int>("RacePoints");

                    b.Property<DateTime>("Time");

                    b.HasKey("DriverId", "RaceId");

                    b.ToTable("DriversRaces");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.F1CafeUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorId")
                        .IsRequired();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreatedOn");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Summary");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("News");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerId")
                        .IsRequired();

                    b.Property<DateTime>("OrderedOn");

                    b.Property<int>("RaceId");

                    b.Property<int>("TicketsCount");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RaceId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Race", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("NumberOfLaps");

                    b.Property<decimal>("RaceDistance");

                    b.Property<int>("ScheduleId");

                    b.Property<int>("TotalTickets");

                    b.Property<int>("TrackId");

                    b.HasKey("Id");

                    b.HasIndex("ScheduleId")
                        .IsUnique();

                    b.HasIndex("TrackId")
                        .IsUnique();

                    b.ToTable("Races");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Practice1Start");

                    b.Property<DateTime>("Practice2Start");

                    b.Property<DateTime>("Practice3Start");

                    b.Property<DateTime>("QualifyingStart");

                    b.Property<int>("RaceId");

                    b.Property<DateTime>("RaceStart");

                    b.HasKey("Id");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Statistics", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CurrentSeasonPoints");

                    b.Property<int>("DriverId");

                    b.Property<int>("Participations");

                    b.Property<int>("Podiums");

                    b.Property<int>("TotalPoints");

                    b.Property<int>("WorldChampionships");

                    b.HasKey("Id");

                    b.ToTable("Statistics");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Base")
                        .IsRequired();

                    b.Property<DateTime>("EntryYear");

                    b.Property<string>("FullName");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Nationality")
                        .IsRequired();

                    b.Property<string>("TeamChief")
                        .IsRequired();

                    b.Property<string>("TeamLogo");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("CircuitLength");

                    b.Property<string>("ImageUrl");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int>("RaceId");

                    b.Property<DateTime>("TrackRecord");

                    b.HasKey("Id");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Car", b =>
                {
                    b.HasOne("F1Cafe.Data.Models.Driver", "Driver")
                        .WithOne("Car")
                        .HasForeignKey("F1Cafe.Data.Models.Car", "DriverId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("F1Cafe.Data.Models.Team", "Team")
                        .WithMany("Cars")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Comment", b =>
                {
                    b.HasOne("F1Cafe.Data.Models.F1CafeUser", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("F1Cafe.Data.Models.News", "News")
                        .WithMany("Comments")
                        .HasForeignKey("NewsId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Driver", b =>
                {
                    b.HasOne("F1Cafe.Data.Models.Statistics", "Statistics")
                        .WithOne("Driver")
                        .HasForeignKey("F1Cafe.Data.Models.Driver", "StatisticsId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("F1Cafe.Data.Models.Team", "Team")
                        .WithMany("Drivers")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("F1Cafe.Data.Models.DriversRaces", b =>
                {
                    b.HasOne("F1Cafe.Data.Models.Driver", "Driver")
                        .WithMany("Races")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("F1Cafe.Data.Models.Race", "Race")
                        .WithMany("Drivers")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("F1Cafe.Data.Models.News", b =>
                {
                    b.HasOne("F1Cafe.Data.Models.F1CafeUser", "Author")
                        .WithMany("News")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Order", b =>
                {
                    b.HasOne("F1Cafe.Data.Models.F1CafeUser", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("F1Cafe.Data.Models.Race", "Race")
                        .WithMany("Orders")
                        .HasForeignKey("RaceId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("F1Cafe.Data.Models.Race", b =>
                {
                    b.HasOne("F1Cafe.Data.Models.Schedule", "Schedule")
                        .WithOne("Race")
                        .HasForeignKey("F1Cafe.Data.Models.Race", "ScheduleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("F1Cafe.Data.Models.Track", "Track")
                        .WithOne("Race")
                        .HasForeignKey("F1Cafe.Data.Models.Race", "TrackId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("F1Cafe.Data.Models.F1CafeUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("F1Cafe.Data.Models.F1CafeUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("F1Cafe.Data.Models.F1CafeUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("F1Cafe.Data.Models.F1CafeUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}