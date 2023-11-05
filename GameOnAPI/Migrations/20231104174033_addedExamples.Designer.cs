﻿// <auto-generated />
using System;
using GameOnAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GameOnAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231104174033_addedExamples")]
    partial class addedExamples
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameOnAPI.Models.MatchParticipation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GoalsScored")
                        .HasColumnType("int");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<int>("TeamPlayedFor")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("UserId");

                    b.ToTable("MatchParticipation");
                });

            modelBuilder.Entity("GameOnAPI.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FavoriteTeam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("MatchId")
                        .HasColumnType("int");

                    b.Property<int?>("MatchId1")
                        .HasColumnType("int");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfileImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<int>("experienceLevel")
                        .HasColumnType("int");

                    b.Property<int>("position")
                        .HasColumnType("int");

                    b.Property<int>("preferredFoot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("MatchId1");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = "324u3943583404",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a962336d-70be-4494-9d53-ea3ecd9b9259",
                            Email = "user1@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Liverpool",
                            Height = 175.5,
                            Location = "Bchamoun",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile1.jpg",
                            SecurityStamp = "71386c20-0fb4-4a1e-8e9a-ea95e0582ae5",
                            TwoFactorEnabled = false,
                            UserName = "Samer",
                            Weight = 70.299999999999997,
                            experienceLevel = 2,
                            position = 0,
                            preferredFoot = 0
                        },
                        new
                        {
                            Id = "32ewdewd83404",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1bd63788-2c6e-4325-9779-20d629b47d5b",
                            Email = "user2@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Barcelona",
                            Height = 180.0,
                            Location = "Saida",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile2.jpg",
                            SecurityStamp = "e333bcf8-212c-40a6-990d-fc99cc7b99c6",
                            TwoFactorEnabled = false,
                            UserName = "Ali",
                            Weight = 75.200000000000003,
                            experienceLevel = 0,
                            position = 2,
                            preferredFoot = 1
                        },
                        new
                        {
                            Id = "32322432nvfvfwdewd83404",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5ab3769f-373c-4642-ada2-bfc19bb436af",
                            Email = "user3@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Real Madrid",
                            Height = 172.0,
                            Location = "Beirut",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile3.jpg",
                            SecurityStamp = "d522cd36-f030-40f1-9846-bbef5fa7439f",
                            TwoFactorEnabled = false,
                            UserName = "Omar",
                            Weight = 68.5,
                            experienceLevel = 2,
                            position = 1,
                            preferredFoot = 0
                        },
                        new
                        {
                            Id = "3232onffenmessi8marvfwdewd83404",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0138c9a7-01ff-49fd-9b54-7041c15e5caa",
                            Email = "user3@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Napoli",
                            Height = 172.0,
                            Location = "Aramoun",
                            LockoutEnabled = false,
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile4.jpg",
                            SecurityStamp = "90d27fb7-9dda-43a4-b3f0-bd26a54a3210",
                            TwoFactorEnabled = false,
                            UserName = "Hussein",
                            Weight = 68.5,
                            experienceLevel = 2,
                            position = 1,
                            preferredFoot = 0
                        });
                });

            modelBuilder.Entity("Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DeadlineRequestsDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Team1GoalCount")
                        .HasColumnType("int");

                    b.Property<int>("Team2GoalCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Match");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            DeadlineRequestsDateTime = new DateTime(2023, 11, 5, 19, 40, 33, 423, DateTimeKind.Local).AddTicks(4070),
                            EndDateTime = new DateTime(2023, 11, 6, 22, 40, 33, 423, DateTimeKind.Local).AddTicks(4064),
                            FieldName = "Field 2",
                            Location = "Sample Location 2",
                            PlayerCount = 8,
                            StartDateTime = new DateTime(2023, 11, 6, 19, 40, 33, 423, DateTimeKind.Local).AddTicks(4008),
                            Team1GoalCount = 1,
                            Team2GoalCount = 2
                        },
                        new
                        {
                            Id = 2,
                            DeadlineRequestsDateTime = new DateTime(2023, 11, 5, 17, 40, 33, 423, DateTimeKind.Local).AddTicks(4084),
                            EndDateTime = new DateTime(2023, 11, 7, 21, 40, 33, 423, DateTimeKind.Local).AddTicks(4081),
                            FieldName = "Field 3",
                            Location = "Sample Location 3",
                            PlayerCount = 12,
                            StartDateTime = new DateTime(2023, 11, 7, 19, 40, 33, 423, DateTimeKind.Local).AddTicks(4078),
                            Team1GoalCount = 3,
                            Team2GoalCount = 1
                        },
                        new
                        {
                            Id = 1,
                            DeadlineRequestsDateTime = new DateTime(2023, 11, 5, 15, 40, 33, 423, DateTimeKind.Local).AddTicks(4096),
                            EndDateTime = new DateTime(2023, 11, 8, 21, 40, 33, 423, DateTimeKind.Local).AddTicks(4093),
                            FieldName = "Field 4",
                            Location = "Sample Location 4",
                            PlayerCount = 16,
                            StartDateTime = new DateTime(2023, 11, 8, 19, 40, 33, 423, DateTimeKind.Local).AddTicks(4089),
                            Team1GoalCount = 2,
                            Team2GoalCount = 4
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("GameOnAPI.Models.MatchParticipation", b =>
                {
                    b.HasOne("Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameOnAPI.Models.User", "User")
                        .WithMany("MatchParticipations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Match");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GameOnAPI.Models.User", b =>
                {
                    b.HasOne("Match", null)
                        .WithMany("Team1")
                        .HasForeignKey("MatchId");

                    b.HasOne("Match", null)
                        .WithMany("Team2")
                        .HasForeignKey("MatchId1");
                });

            modelBuilder.Entity("GameOnAPI.Models.User", b =>
                {
                    b.Navigation("MatchParticipations");
                });

            modelBuilder.Entity("Match", b =>
                {
                    b.Navigation("Team1");

                    b.Navigation("Team2");
                });
#pragma warning restore 612, 618
        }
    }
}
