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
    [Migration("20231231233741_updateMatches3")]
    partial class updateMatches3
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
                            ConcurrencyStamp = "50df3b8b-7179-4267-a5e1-5b096bc253fc",
                            Email = "user1@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Liverpool",
                            Height = 175.5,
                            Location = "Bchamoun",
                            LockoutEnabled = false,
                            Name = "Samer Shalabi",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile1.jpg",
                            SecurityStamp = "89b9036e-e042-46a5-b356-62e1c2be9aec",
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
                            ConcurrencyStamp = "4cef7167-af5c-446f-8a61-162b8d23be4d",
                            Email = "user2@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Barcelona",
                            Height = 180.0,
                            Location = "Saida",
                            LockoutEnabled = false,
                            Name = "Ali Hussein",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile2.jpg",
                            SecurityStamp = "fbf9d46c-4879-4c9e-8f2a-c0060eee277b",
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
                            ConcurrencyStamp = "52e6c55b-3289-4643-9dba-597d7e55087e",
                            Email = "user3@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Real Madrid",
                            Height = 172.0,
                            Location = "Beirut",
                            LockoutEnabled = false,
                            Name = "Omar Shalabi",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile3.jpg",
                            SecurityStamp = "01efb863-30f8-4a7b-b060-1d17912c2770",
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
                            ConcurrencyStamp = "38ccb328-1f0f-4e49-a714-263ad33ef16c",
                            Email = "user3@example.com",
                            EmailConfirmed = false,
                            FavoriteTeam = "Napoli",
                            Height = 172.0,
                            Location = "Aramoun",
                            LockoutEnabled = false,
                            Name = "Hussein Ali",
                            PhoneNumberConfirmed = false,
                            ProfileImageUrl = "profile4.jpg",
                            SecurityStamp = "06e043e4-c0f9-4446-91cd-1c58a1e5e5b2",
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

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerCount")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("feePerPlayer")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("FieldId");

                    b.HasIndex("UserId");

                    b.ToTable("Match");

                    b.HasData(
                        new
                        {
                            Id = 13,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 1, 13, 13, 37, 40, 837, DateTimeKind.Local).AddTicks(6215),
                            EndDateTime = new DateTime(2024, 1, 3, 4, 37, 40, 837, DateTimeKind.Local).AddTicks(6211),
                            Featured = true,
                            FieldId = 3,
                            Notes = "",
                            PlayerCount = 8,
                            StartDateTime = new DateTime(2024, 1, 3, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6155),
                            UserId = "069a5b6e-deb5-4dcc-bfd7-92dce2aea524",
                            feePerPlayer = 7.0
                        },
                        new
                        {
                            Id = 12,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 1, 9, 9, 37, 40, 837, DateTimeKind.Local).AddTicks(6226),
                            EndDateTime = new DateTime(2024, 1, 4, 3, 37, 40, 837, DateTimeKind.Local).AddTicks(6223),
                            Featured = true,
                            FieldId = 2,
                            Notes = "",
                            PlayerCount = 12,
                            StartDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            UserId = "141b7af4-e40a-4330-b7cf-9b85cb579c7c",
                            feePerPlayer = 10.0
                        },
                        new
                        {
                            Id = 10,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 1, 6, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6238),
                            EndDateTime = new DateTime(2024, 1, 5, 3, 37, 40, 837, DateTimeKind.Local).AddTicks(6235),
                            Featured = true,
                            FieldId = 1,
                            Notes = "",
                            PlayerCount = 16,
                            StartDateTime = new DateTime(2024, 1, 5, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6232),
                            UserId = "141b7af4-e40a-4330-b7cf-9b85cb579c7c",
                            feePerPlayer = 12.0
                        },
                        new
                        {
                            Id = 3,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 1, 13, 13, 37, 40, 837, DateTimeKind.Local).AddTicks(6249),
                            EndDateTime = new DateTime(2024, 1, 3, 4, 37, 40, 837, DateTimeKind.Local).AddTicks(6246),
                            Featured = true,
                            FieldId = 3,
                            Notes = "",
                            PlayerCount = 8,
                            StartDateTime = new DateTime(2024, 1, 3, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6242),
                            UserId = "069a5b6e-deb5-4dcc-bfd7-92dce2aea524",
                            feePerPlayer = 7.0
                        },
                        new
                        {
                            Id = 2,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 1, 9, 9, 37, 40, 837, DateTimeKind.Local).AddTicks(6260),
                            EndDateTime = new DateTime(2024, 1, 4, 3, 37, 40, 837, DateTimeKind.Local).AddTicks(6257),
                            Featured = true,
                            FieldId = 2,
                            Notes = "",
                            PlayerCount = 12,
                            StartDateTime = new DateTime(2024, 1, 4, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6254),
                            UserId = "141b7af4-e40a-4330-b7cf-9b85cb579c7c",
                            feePerPlayer = 10.0
                        },
                        new
                        {
                            Id = 1,
                            CreationDateTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DeadlineRequestsDateTime = new DateTime(2024, 1, 6, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6271),
                            EndDateTime = new DateTime(2024, 1, 5, 3, 37, 40, 837, DateTimeKind.Local).AddTicks(6268),
                            Featured = true,
                            FieldId = 1,
                            Notes = "",
                            PlayerCount = 16,
                            StartDateTime = new DateTime(2024, 1, 5, 1, 37, 40, 837, DateTimeKind.Local).AddTicks(6265),
                            UserId = "141b7af4-e40a-4330-b7cf-9b85cb579c7c",
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

                    b.HasOne("GameOnAPI.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

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
