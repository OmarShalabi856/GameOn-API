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
    [Migration("20231110225831_addedNameField")]
    partial class addedNameField
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

                    b.HasIndex("MatchId");

                    b.HasIndex("MatchId1");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = "324u3943583404",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f8c9ae19-e496-49f0-8c22-eb051df92067",
                            Email = "user1@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Liverpool",
                            Height = 175.5,
                            Location = "Bchamoun",
                            LockoutEnabled = false,
                            Name = "Samer Shalabi",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile1.jpg",
                            SecurityStamp = "a4b86f86-4df2-41af-8553-0cdf0a1f4197",
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
                            ConcurrencyStamp = "2be68cbb-e306-4423-a1aa-988caf89fd45",
                            Email = "user2@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Barcelona",
                            Height = 180.0,
                            Location = "Saida",
                            LockoutEnabled = false,
                            Name = "Ali Hussein",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile2.jpg",
                            SecurityStamp = "74c6cdb8-9798-4132-b8c4-f439d5974314",
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
                            ConcurrencyStamp = "90ed0c00-4cf2-42ae-8851-12930a8cb4f5",
                            Email = "user3@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Real Madrid",
                            Height = 172.0,
                            Location = "Beirut",
                            LockoutEnabled = false,
                            Name = "Omar Shalabi",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile3.jpg",
                            SecurityStamp = "240e0c4b-8eae-4314-b9c3-692768cc1718",
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
                            ConcurrencyStamp = "364102c0-5406-43b8-a736-bcc39a2df446",
                            Email = "user3@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Napoli",
                            Height = 172.0,
                            Location = "Aramoun",
                            LockoutEnabled = false,
                            Name = "Hussein Ali",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile4.jpg",
                            SecurityStamp = "53c0cb5a-ab50-40cb-b0af-8d5a14e8d227",
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

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<int>("PlayerCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Team1GoalCount")
                        .HasColumnType("int");

                    b.Property<int>("Team2GoalCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.ToTable("Match");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            DeadlineRequestsDateTime = new DateTime(2023, 11, 23, 12, 58, 30, 871, DateTimeKind.Local).AddTicks(8560),
                            EndDateTime = new DateTime(2023, 11, 13, 3, 58, 30, 871, DateTimeKind.Local).AddTicks(8557),
                            Featured = true,
                            FieldId = 3,
                            PlayerCount = 8,
                            StartDateTime = new DateTime(2023, 11, 13, 0, 58, 30, 871, DateTimeKind.Local).AddTicks(8506),
                            Team1GoalCount = 1,
                            Team2GoalCount = 2
                        },
                        new
                        {
                            Id = 2,
                            DeadlineRequestsDateTime = new DateTime(2023, 11, 19, 8, 58, 30, 871, DateTimeKind.Local).AddTicks(8573),
                            EndDateTime = new DateTime(2023, 11, 14, 2, 58, 30, 871, DateTimeKind.Local).AddTicks(8570),
                            Featured = true,
                            FieldId = 2,
                            PlayerCount = 12,
                            StartDateTime = new DateTime(2023, 11, 14, 0, 58, 30, 871, DateTimeKind.Local).AddTicks(8567),
                            Team1GoalCount = 3,
                            Team2GoalCount = 1
                        },
                        new
                        {
                            Id = 1,
                            DeadlineRequestsDateTime = new DateTime(2023, 11, 16, 0, 58, 30, 871, DateTimeKind.Local).AddTicks(8584),
                            EndDateTime = new DateTime(2023, 11, 15, 2, 58, 30, 871, DateTimeKind.Local).AddTicks(8581),
                            Featured = true,
                            FieldId = 1,
                            PlayerCount = 16,
                            StartDateTime = new DateTime(2023, 11, 15, 0, 58, 30, 871, DateTimeKind.Local).AddTicks(8578),
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
                    b.Navigation("Team1");

                    b.Navigation("Team2");
                });
#pragma warning restore 612, 618
        }
    }
}
