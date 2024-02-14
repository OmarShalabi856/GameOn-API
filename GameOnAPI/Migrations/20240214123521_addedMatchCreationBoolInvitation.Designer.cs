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
    [Migration("20240214123521_addedMatchCreationBoolInvitation")]
    partial class addedMatchCreationBoolInvitation
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

            modelBuilder.Entity("GameOnAPI.Models.Invitation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("ExpiryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvitedPlayerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MatchCaptainId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("MatchCreation")
                        .HasColumnType("bit");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("InvitedPlayerId");

                    b.HasIndex("MatchCaptainId");

                    b.HasIndex("MatchId");

                    b.ToTable("Invitation");
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

                    b.Property<double>("xPosition")
                        .HasColumnType("float");

                    b.Property<double>("yPosition")
                        .HasColumnType("float");

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
                            position = 5,
                            xPosition = 0.0,
                            yPosition = 0.0
                        },
                        new
                        {
                            Id = 2,
                            MatchId = 1,
                            Rating = 0.0,
                            TeamPlayingFor = 2,
                            UserId = "32ewdewd83404",
                            position = 0,
                            xPosition = 0.0,
                            yPosition = 0.0
                        });
                });

            modelBuilder.Entity("GameOnAPI.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.Property<int>("experienceLevel")
                        .HasColumnType("int");

                    b.Property<int>("position")
                        .HasColumnType("int");

                    b.Property<int>("preferredFoot")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("User", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "324u3943583404",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ae9d4e45-2ff9-4db4-80db-98a8af7f3942",
                            Email = "user1@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Liverpool",
                            Height = 175.5,
                            Location = "Bchamoun",
                            LockoutEnabled = false,
                            Name = "Samer Shalabi",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile1.jpg",
                            SecurityStamp = "9e910cda-5e3b-452d-9fea-ef21fb81e4d5",
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
                            ConcurrencyStamp = "d6d04b13-926c-4167-a3c4-6f6ba9a24ef3",
                            Email = "user2@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Barcelona",
                            Height = 180.0,
                            Location = "Saida",
                            LockoutEnabled = false,
                            Name = "Ali Hussein",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile2.jpg",
                            SecurityStamp = "702ab00a-76ee-4fcd-820e-aefc41c81fce",
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
                            ConcurrencyStamp = "9f43ae44-ebb1-492c-9a16-4c6cd63fa41c",
                            Email = "user3@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Real Madrid",
                            Height = 172.0,
                            Location = "Beirut",
                            LockoutEnabled = false,
                            Name = "Omar Shalabi",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile3.jpg",
                            SecurityStamp = "205e6b0f-990e-449a-856f-3b8396c11dae",
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
                            ConcurrencyStamp = "bd472e72-1359-4687-9f13-b87aaad9aab7",
                            Email = "user3@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Napoli",
                            Height = 172.0,
                            Location = "Aramoun",
                            LockoutEnabled = false,
                            Name = "Hussein Ali",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile4.jpg",
                            SecurityStamp = "3f0004a8-29f2-4a5b-9d5b-7a21af60941a",
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

                    b.Property<string>("AgeGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeadlineRequestsDateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<int>("FieldId")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamOneCaptainId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TeamTwoCaptainId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("feePerPlayer")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.HasIndex("TeamOneCaptainId");

                    b.HasIndex("TeamTwoCaptainId");

                    b.ToTable("Match");

                    b.HasData(
                        new
                        {
                            Id = 13,
                            AgeGroup = "Under 10",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 2, 27, 2, 35, 21, 36, DateTimeKind.Local).AddTicks(2141),
                            EndDateTime = new DateTime(2024, 2, 16, 17, 35, 21, 36, DateTimeKind.Local).AddTicks(2136),
                            Featured = true,
                            FieldId = 3,
                            Gender = "Male",
                            Notes = "",
                            PlayerCount = 8,
                            StartDateTime = new DateTime(2024, 2, 16, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2086),
                            Status = "Pending Confirmation",
                            TeamOneCaptainId = "069a5b6e-deb5-4dcc-bfd7-92dce2aea524",
                            TeamTwoCaptainId = "141b7af4-e40a-4330-b7cf-9b85cb579c7c",
                            feePerPlayer = 7.0
                        },
                        new
                        {
                            Id = 12,
                            AgeGroup = "Under10",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 2, 22, 22, 35, 21, 36, DateTimeKind.Local).AddTicks(2153),
                            EndDateTime = new DateTime(2024, 2, 17, 16, 35, 21, 36, DateTimeKind.Local).AddTicks(2150),
                            Featured = true,
                            FieldId = 2,
                            Gender = "Male",
                            Notes = "",
                            PlayerCount = 12,
                            StartDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Pending Confirmation",
                            TeamOneCaptainId = "141b7af4-e40a-4330-b7cf-9b85cb579c7c",
                            TeamTwoCaptainId = "069a5b6e-deb5-4dcc-bfd7-92dce2aea524",
                            feePerPlayer = 10.0
                        },
                        new
                        {
                            Id = 10,
                            AgeGroup = "10-15",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 2, 19, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2165),
                            EndDateTime = new DateTime(2024, 2, 18, 16, 35, 21, 36, DateTimeKind.Local).AddTicks(2162),
                            Featured = true,
                            FieldId = 1,
                            Gender = "Female",
                            Notes = "",
                            PlayerCount = 16,
                            StartDateTime = new DateTime(2024, 2, 18, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2159),
                            Status = "Pending Confirmation",
                            TeamOneCaptainId = "141b7af4-e40a-4330-b7cf-9b85cb579c7c",
                            TeamTwoCaptainId = "069a5b6e-deb5-4dcc-bfd7-92dce2aea524",
                            feePerPlayer = 12.0
                        },
                        new
                        {
                            Id = 3,
                            AgeGroup = "18+",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 2, 27, 2, 35, 21, 36, DateTimeKind.Local).AddTicks(2177),
                            EndDateTime = new DateTime(2024, 2, 16, 17, 35, 21, 36, DateTimeKind.Local).AddTicks(2174),
                            Featured = true,
                            FieldId = 3,
                            Gender = "Male",
                            Notes = "",
                            PlayerCount = 8,
                            StartDateTime = new DateTime(2024, 2, 16, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2171),
                            Status = "Pending Confirmation",
                            TeamOneCaptainId = "141b7af4-e40a-4330-b7cf-9b85cb579c7c",
                            TeamTwoCaptainId = "069a5b6e-deb5-4dcc-bfd7-92dce2aea524",
                            feePerPlayer = 7.0
                        },
                        new
                        {
                            Id = 2,
                            AgeGroup = "18+",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 2, 22, 22, 35, 21, 36, DateTimeKind.Local).AddTicks(2188),
                            EndDateTime = new DateTime(2024, 2, 17, 16, 35, 21, 36, DateTimeKind.Local).AddTicks(2185),
                            Featured = true,
                            FieldId = 2,
                            Gender = "Male",
                            Notes = "",
                            PlayerCount = 12,
                            StartDateTime = new DateTime(2024, 2, 17, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2182),
                            Status = "Pending Confirmation",
                            TeamOneCaptainId = "141b7af4-e40a-4330-b7cf-9b85cb579c7c",
                            TeamTwoCaptainId = "069a5b6e-deb5-4dcc-bfd7-92dce2aea524",
                            feePerPlayer = 10.0
                        },
                        new
                        {
                            Id = 1,
                            AgeGroup = "10-15",
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 2, 19, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2199),
                            EndDateTime = new DateTime(2024, 2, 18, 16, 35, 21, 36, DateTimeKind.Local).AddTicks(2196),
                            Featured = true,
                            FieldId = 1,
                            Gender = "Female",
                            Notes = "",
                            PlayerCount = 16,
                            StartDateTime = new DateTime(2024, 2, 18, 14, 35, 21, 36, DateTimeKind.Local).AddTicks(2193),
                            Status = "Pending Confirmation",
                            TeamOneCaptainId = "141b7af4-e40a-4330-b7cf-9b85cb579c7c",
                            TeamTwoCaptainId = "069a5b6e-deb5-4dcc-bfd7-92dce2aea524",
                            feePerPlayer = 12.0
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<string>", b =>
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

                    b.ToTable("Roles", (string)null);
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
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
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
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUserRole<string>");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("UserRoles", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUserRole<string>");

                    b.Property<string>("RoleId1")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UserId1")
                        .HasColumnType("nvarchar(450)");

                    b.HasIndex("RoleId1");

                    b.HasIndex("UserId1");

                    b.HasDiscriminator().HasValue("UserRoles");
                });

            modelBuilder.Entity("GameOnAPI.Models.Invitation", b =>
                {
                    b.HasOne("GameOnAPI.Models.User", "InvitedPlayer")
                        .WithMany()
                        .HasForeignKey("InvitedPlayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameOnAPI.Models.User", "MatchCaptain")
                        .WithMany()
                        .HasForeignKey("MatchCaptainId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InvitedPlayer");

                    b.Navigation("Match");

                    b.Navigation("MatchCaptain");
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

                    b.HasOne("GameOnAPI.Models.User", "TeamOneCaptain")
                        .WithMany()
                        .HasForeignKey("TeamOneCaptainId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("GameOnAPI.Models.User", "TeamTwoCaptain")
                        .WithMany()
                        .HasForeignKey("TeamTwoCaptainId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("TeamOneCaptain");

                    b.Navigation("TeamTwoCaptain");

                    b.Navigation("field");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GameOnAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GameOnAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameOnAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GameOnAPI.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("UserRoles", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GameOnAPI.Models.User", null)
                        .WithMany("userRoles")
                        .HasForeignKey("UserId1");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("GameOnAPI.Models.User", b =>
                {
                    b.Navigation("MatchParticipations");

                    b.Navigation("userRoles");
                });

            modelBuilder.Entity("Match", b =>
                {
                    b.Navigation("Participations");
                });
#pragma warning restore 612, 618
        }
    }
}
