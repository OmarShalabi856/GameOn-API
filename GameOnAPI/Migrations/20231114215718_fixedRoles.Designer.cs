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
    [Migration("20231114215718_fixedRoles")]
    partial class fixedRoles
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GameOnAPI.Models.Field", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FieldImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FieldName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Field");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FieldImage = "https://assets.rappler.com/6677C2B68AF94FD1BD758C065AC43A07/img/43648E3295544C6A8EF16B42BDF2F6D6/6.jpg",
                            FieldName = "AllSports",
                            Location = "Bchamoun"
                        },
                        new
                        {
                            Id = 2,
                            FieldImage = "https://th.bing.com/th/id/R.59f002d1a5d3dae68612a521fb245ffe?rik=2Z9vdMR9H5Ni9g&riu=http%3a%2f%2fwww.artificialturf-grass.com%2fphoto%2fpl11353642-durable_false_turf_playground_soccer_synthetic_grass_environment_friendly.jpg&ehk=z4WhEwLG8xnj49JE3nraLCVHEmerkxdcLha7MK9qDjY%3d&risl=&pid=ImgRaw&r=0",
                            FieldName = "GreenField",
                            Location = "Aley"
                        },
                        new
                        {
                            Id = 3,
                            FieldImage = "https://th.bing.com/th/id/OIP.WNQW57IvkqWmB7lcL08MMgHaE7?pid=ImgDet&w=207&h=138&c=7",
                            FieldName = "KasKas",
                            Location = "Beirut"
                        });
                });

            modelBuilder.Entity("GameOnAPI.Models.MatchParticipation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<int>("TeamPlayingFor")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("position")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MatchId");

                    b.HasIndex("UserId");

                    b.ToTable("MatchParticipation");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MatchId = 1,
                            Rating = 0.0,
                            TeamPlayingFor = 1,
                            UserId = "3232onffenmessi8marvfwdewd83404",
                            position = 5
                        },
                        new
                        {
                            Id = 2,
                            MatchId = 1,
                            Rating = 0.0,
                            TeamPlayingFor = 2,
                            UserId = "32ewdewd83404",
                            position = 0
                        });
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = "324u3943583404",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e7146be2-dde7-44d3-aa00-793c1e22e234",
                            Email = "user1@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Liverpool",
                            Height = 175.5,
                            Location = "Bchamoun",
                            LockoutEnabled = false,
                            Name = "Samer Shalabi",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile1.jpg",
                            SecurityStamp = "1fa75e06-a51f-4355-97f0-f6bda708a121",
                            TwoFactorEnabled = false,
                            UserName = "Samer",
                            Weight = 70.299999999999997,
                            experienceLevel = 2,
                            position = 4,
                            preferredFoot = 0
                        },
                        new
                        {
                            Id = "32ewdewd83404",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "60aaaa5d-0010-4210-8568-e0d3b01f7821",
                            Email = "user2@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Barcelona",
                            Height = 180.0,
                            Location = "Saida",
                            LockoutEnabled = false,
                            Name = "Ali Hussein",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile2.jpg",
                            SecurityStamp = "b99e37f8-1f46-4fdf-8d54-1a6983d73868",
                            TwoFactorEnabled = false,
                            UserName = "Ali",
                            Weight = 75.200000000000003,
                            experienceLevel = 0,
                            position = 7,
                            preferredFoot = 1
                        },
                        new
                        {
                            Id = "32322432nvfvfwdewd83404",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "00c5f855-82df-4c7a-847a-b20258ba6b3c",
                            Email = "user3@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Real Madrid",
                            Height = 172.0,
                            Location = "Beirut",
                            LockoutEnabled = false,
                            Name = "Omar Shalabi",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile3.jpg",
                            SecurityStamp = "9265fda5-d4a8-4589-9083-5dac97420f06",
                            TwoFactorEnabled = false,
                            UserName = "Omar",
                            Weight = 68.5,
                            experienceLevel = 2,
                            position = 0,
                            preferredFoot = 0
                        },
                        new
                        {
                            Id = "3232onffenmessi8marvfwdewd83404",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "23039499-1608-461f-8eff-7fd4b2820c8a",
                            Email = "user3@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Napoli",
                            Height = 172.0,
                            Location = "Aramoun",
                            LockoutEnabled = false,
                            Name = "Hussein Ali",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile4.jpg",
                            SecurityStamp = "dfb606e4-f50d-4ffc-abc1-686ccb3af3bf",
                            TwoFactorEnabled = false,
                            UserName = "Hussein",
                            Weight = 68.5,
                            experienceLevel = 2,
                            position = 6,
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

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.ToTable("Match");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            DeadlineRequestsDateTime = new DateTime(2023, 11, 27, 11, 57, 17, 605, DateTimeKind.Local).AddTicks(5082),
                            EndDateTime = new DateTime(2023, 11, 17, 2, 57, 17, 605, DateTimeKind.Local).AddTicks(5075),
                            Featured = true,
                            FieldId = 3,
                            PlayerCount = 8,
                            StartDateTime = new DateTime(2023, 11, 16, 23, 57, 17, 605, DateTimeKind.Local).AddTicks(5024)
                        },
                        new
                        {
                            Id = 2,
                            DeadlineRequestsDateTime = new DateTime(2023, 11, 23, 7, 57, 17, 605, DateTimeKind.Local).AddTicks(5095),
                            EndDateTime = new DateTime(2023, 11, 18, 1, 57, 17, 605, DateTimeKind.Local).AddTicks(5092),
                            Featured = true,
                            FieldId = 2,
                            PlayerCount = 12,
                            StartDateTime = new DateTime(2023, 11, 17, 23, 57, 17, 605, DateTimeKind.Local).AddTicks(5089)
                        },
                        new
                        {
                            Id = 1,
                            DeadlineRequestsDateTime = new DateTime(2023, 11, 19, 23, 57, 17, 605, DateTimeKind.Local).AddTicks(5105),
                            EndDateTime = new DateTime(2023, 11, 19, 1, 57, 17, 605, DateTimeKind.Local).AddTicks(5102),
                            Featured = true,
                            FieldId = 1,
                            PlayerCount = 16,
                            StartDateTime = new DateTime(2023, 11, 18, 23, 57, 17, 605, DateTimeKind.Local).AddTicks(5099)
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
                        .WithMany("Participations")
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

            modelBuilder.Entity("Match", b =>
                {
                    b.HasOne("GameOnAPI.Models.Field", "field")
                        .WithMany()
                        .HasForeignKey("FieldId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("field");
                });

            modelBuilder.Entity("GameOnAPI.Models.User", b =>
                {
                    b.Navigation("MatchParticipations");
                });

            modelBuilder.Entity("Match", b =>
                {
                    b.Navigation("Participations");
                });
#pragma warning restore 612, 618
        }
    }
}